using OpenRuCapture.Libs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class FrmMainUI : Form
    {
        private string _fileName = string.Empty;
        private readonly List<CustomShape> _shapes;
        private GraphicsPath _graphicsPath;
        private Shape _selectedShape = Shape.Pen;
        private Color _selectedColor = Color.Red;
        private PenSize _selectedSize = PenSize.Fine;
        private Pen _selectedPen;
        private readonly Pen _highlighterPen;
        private bool _isSaved = false;
        private CustomShape _shape;
        private int _x;
        private int _y;

        public FrmMainUI()
        {
            InitializeComponent();
            _shapes = new List<CustomShape>();
            _highlighterPen = new Pen(Color.FromArgb(95, Color.Yellow), (int)PenSize.Thick);
            UpdatePen();
        }

        public FrmMainUI(string fileName)
            : this()
        {
            _fileName = fileName;
            LoadImage(_fileName);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_isSaved && _shapes.Count >= 1)
            {
                var result = MessageBox.Show("Текущий снимок экрана изменен. Вы хотите его сохранить?",
                    "Редактор скириншотов", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveAsFile();
                    if (!_isSaved)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PNG File|*.png|JPEG File|*.jpeg;*.jpg|BMP File|*.bmp|TIFF File|*.tiff|GIF File|*.gif|WMF File|*.wmf"; ;
                openFileDialog.CheckFileExists = true;
                openFileDialog.Multiselect = false;
                openFileDialog.ReadOnlyChecked = false;
                openFileDialog.Title = "Открыть файл изображения";
                openFileDialog.ShowReadOnly = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadImage(openFileDialog.FileName);
                }
            }
        }

        private void LoadImage(string fileName)
        {
            using (Image img = Image.FromFile(fileName))
            {
                _shapes.Clear();
                picPreview.Image = new Bitmap(img);
                _fileName = fileName;
                toolsToolStripMenuItem.Enabled = true;
                MoveImageToCenter();
            }
        }

        private void picPreview_MouseDown(object sender, MouseEventArgs e)
        {
            if (_fileName.Length <= 0)
            {
                return;
            }

            _x = e.X;
            _y = e.Y;

            switch (_selectedShape)
            {
                case Shape.Unknown:
                    break;
                case Shape.Pen:
                case Shape.Highlighter:
                    _graphicsPath = new GraphicsPath();
                    break;
                case Shape.Eraser:
                    foreach (var path in _shapes)
                    {
                        if (path.Path.GetBounds().Contains(e.Location))
                        {
                            _shapes.Remove(path);
                            picPreview.Invalidate();
                            break;
                        }
                    }
                    break;
                case Shape.Text:
                    frmInsertText frmInsertTextDlg = new frmInsertText();
                    if (frmInsertTextDlg.ShowDialog(this) == DialogResult.OK)
                    {
                        CustomShape customShape = new CustomShape();
                        customShape.Shape = Shape.Text;
                        customShape.Pen = new Pen(_selectedColor, 1);
                        GraphicsPath graphicsPath = new GraphicsPath();
                        graphicsPath.AddString(frmInsertTextDlg.SelectedText,
                            frmInsertTextDlg.SelectedFont.FontFamily, (int)frmInsertTextDlg.SelectedFont.Style,
                            frmInsertTextDlg.SelectedFont.Size, e.Location, StringFormat.GenericTypographic);
                        graphicsPath.FillMode = FillMode.Winding;
                        customShape.Path = graphicsPath;
                        _shapes.Add(customShape);
                        picPreview.Invalidate();
                    }
                    break;
                case Shape.Selection:
                    picPreview.Refresh();
                    foreach (var shape in _shapes)
                    {
                        if (shape.Path.GetBounds().Contains(e.Location))
                        {
                            var rectf = shape.Path.GetBounds();
                            var rect = new Rectangle((int)rectf.X, (int)rectf.Y, (int)rectf.Width, (int)rectf.Height);
                            var graphics = picPreview.CreateGraphics();
                            ControlPaint.DrawReversibleFrame(picPreview.RectangleToScreen(rect), Color.BurlyWood, FrameStyle.Dashed);
                            _shape = shape;
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void picPreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (_graphicsPath != null)
            {
                _graphicsPath.AddLine(e.X, e.Y, e.X, e.Y);
                using (Graphics graphics = picPreview.CreateGraphics())
                {
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    var pen = _selectedShape == Shape.Highlighter ? _highlighterPen : _selectedPen;
                    graphics.DrawPath(pen, _graphicsPath);
                }
            }

            if (null != _shape)
            {
                Matrix matrix = new Matrix();
                matrix.Translate(e.X - _x, e.Y - _y);
                _shape.Path.Transform(matrix);
                _x = e.X;
                _y = e.Y;
                picPreview.Invalidate();
            }
        }

        private void picPreview_MouseUp(object sender, MouseEventArgs e)
        {
            if (_graphicsPath != null)
            {
                var customShape = new CustomShape();
                customShape.Path = _graphicsPath;
                customShape.Pen = _selectedShape == Shape.Highlighter ? _highlighterPen : _selectedPen;
                customShape.Shape = _selectedShape;
                _shapes.Add(customShape);
                _graphicsPath = null;
                picPreview.Invalidate();
            }

            if (null != _shape)
            {
                _shape = null;
            }
        }

        private void picPreview_Paint(object sender, PaintEventArgs e)
        {
            if (_shapes.Count >= 1)
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                foreach (var customShape in _shapes)
                {
                    e.Graphics.DrawPath(customShape.Pen, customShape.Path);
                    if (customShape.Shape == Shape.Text)
                    {
                        e.Graphics.FillPath(_selectedPen.Brush, customShape.Path);
                    }
                }
            }
        }

        private void penToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedShape = Shape.Pen;
            CheckMenuItem(penToolStripMenuItem);
            picPreview.Cursor = new Cursor(Properties.Resources.Pen.GetHicon());
        }

        private void highlighterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedShape = Shape.Highlighter;
            CheckMenuItem(highlighterToolStripMenuItem);
            picPreview.Cursor = new Cursor(Properties.Resources.Highlighter.GetHicon());
        }

        private void eraserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedShape = Shape.Eraser;
            CheckMenuItem(eraserToolStripMenuItem);
            picPreview.Cursor = new Cursor(Properties.Resources.Eraser.GetHicon());
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedSize = PenSize.Fine;
            thickToolStripMenuItem.Checked = false;
            thinToolStripMenuItem.Checked = true;
            mediumToolStripMenuItem.Checked = false;
            UpdatePen();
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedSize = PenSize.Medium;
            thickToolStripMenuItem.Checked = false;
            thinToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = true;
            UpdatePen();
        }

        private void thickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedSize = PenSize.Thick;
            thickToolStripMenuItem.Checked = true;
            thinToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            UpdatePen();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.Red;
            redToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            customToolStripMenuItem.Checked = false;

            UpdatePen();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.Blue;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;
            greenToolStripMenuItem.Checked = false;
            customToolStripMenuItem.Checked = false;
            UpdatePen();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.Green;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = true;
            customToolStripMenuItem.Checked = false;
            UpdatePen();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.AnyColor = true;
                colorDialog.AllowFullOpen = true;
                colorDialog.ShowHelp = false;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedColor = colorDialog.Color;
                    redToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    greenToolStripMenuItem.Checked = false;
                    customToolStripMenuItem.Checked = true;
                    UpdatePen();
                }
            }
        }

        private void UpdatePen()
        {
            _selectedPen = new Pen(_selectedColor, (float)_selectedSize);
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            sendToMailMenuItem6.Enabled = saveToolStripMenuItem.Enabled = saveAsToolStripMenuItem.Enabled = _fileName.Length >= 1;
        }

        private void FrmMainUI_Resize(object sender, EventArgs e)
        {
            MoveImageToCenter();
        }

        private void FrmMainUI_Activated(object sender, EventArgs e)
        {
            MoveImageToCenter();
        }

        private void MoveImageToCenter()
        {
            picPreview.Left = panel1.Width / 2 - picPreview.Width / 2;
            picPreview.Top = panel1.Height / 2 - picPreview.Height / 2;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fileName.Length >= 1)
            {
                ImageFormat imageFormat = GetImageFormat(_fileName);
                DrawImageAndSave(_fileName, imageFormat);
                _isSaved = true;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void SaveAsFile()
        {
            string tempFilename = string.Empty;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = Path.GetFileName(_fileName);
                saveFileDialog.Filter = "PNG File|*.png|JPEG File|*.jpeg|BMP File|*.bmp|TIFF File|*.tiff|GIF File|*.gif|WMF File|*.wmf";
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.ShowHelp = false;
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.AddExtension = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tempFilename = saveFileDialog.FileName;
                    ImageFormat imageFormat = GetImageFormat(tempFilename);
                    DrawImageAndSave(tempFilename, imageFormat);

                    _isSaved = true;
                }

            }
        }

        private static ImageFormat GetImageFormat(string filename)
        {
            ImageFormat imageFormat = ImageFormat.Png;
            switch (Path.GetExtension(filename))
            {
                case ".bmp":
                    imageFormat = ImageFormat.Bmp;
                    break;
                case ".jpg":
                    imageFormat = ImageFormat.Jpeg;
                    break;
                case ".png":
                    imageFormat = ImageFormat.Png;
                    break;
                case ".gif":
                    imageFormat = ImageFormat.Gif;
                    break;
                case ".tiff":
                    imageFormat = ImageFormat.Tiff;
                    break;
                case ".wmf":
                    imageFormat = ImageFormat.Wmf;
                    break;
            }
            return imageFormat;
        }

        private void DrawImageAndSave(string fileName, ImageFormat imageFormat)
        {
            Image image = picPreview.Image;
            using (Graphics graphics = Graphics.FromImage(picPreview.Image))
            {
                if (_shapes.Count >= 1)
                {
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    foreach (var customShape in _shapes)
                    {
                        graphics.DrawPath(customShape.Pen, customShape.Path);
                        if (customShape.Shape == Shape.Text)
                        {
                            graphics.FillPath(_selectedPen.Brush, customShape.Path);
                        }
                    }
                }

                image.Save(fileName, imageFormat);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isSaved && _shapes.Count >= 1)
            {
                var result = MessageBox.Show("Текущий снимок экрана изменен. Вы хотите его сохранить?",
                    "Редактор скриншотов", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveAsFile();
                    if (!_isSaved)
                    {
                        e.Cancel = true;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = string.Format("Редактор скриншотов для OpenRuCapture{0}{0}Copyright © {1} КонтинентСвободы.рф {0}под лицензией GNU GPL v2{0}http://КонтинентСвободы.рф", Environment.NewLine, DateTime.Now.Year);
            MessageBox.Show(message, "О программе", MessageBoxButtons.OK);
        }

        private void toolStripMenuItem5_DropDownOpening(object sender, EventArgs e)
        {
            copyToolStripMenuItem.Enabled = _fileName.Length >= 1;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fileName.Length >= 1)
            {
                Image image = picPreview.Image;
                using (Graphics graphics = Graphics.FromImage(picPreview.Image))
                {
                    if (_shapes.Count >= 1)
                    {
                        graphics.SmoothingMode = SmoothingMode.HighQuality;
                        foreach (var customShape in _shapes)
                        {
                            graphics.DrawPath(customShape.Pen, customShape.Path);
                        }
                    }
                }
                Clipboard.SetImage(image);
            }
        }

        private void sendToMailMenuItem6_Click(object sender, EventArgs e)
        {
            if (_fileName.Length >= 1)
            {
                var mapi = new MAPI();
                mapi.AddAttachment(_fileName);
                mapi.SendMailPopup(string.Empty, _fileName);
            }
        }

        private void toolsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            TextToolStripMenuItem.Enabled = penToolStripMenuItem.Enabled = highlighterToolStripMenuItem.Enabled
                = eraserToolStripMenuItem.Enabled = changeColorToolStripMenuItem.Enabled = _fileName.Length >= 1;
        }

        private void TextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedShape = Shape.Text;
            CheckMenuItem(TextToolStripMenuItem);
            picPreview.Cursor = new Cursor(Properties.Resources.Text.GetHicon());
        }

        private void SelectMenuToolStripItem_Click(object sender, EventArgs e)
        {
            picPreview.Cursor = Cursors.Default;
            _selectedShape = Shape.Selection;
            CheckMenuItem(SelectMenuToolStripItem);
        }

        private void CheckMenuItem(ToolStripMenuItem menuItem)
        {
            ToolStripMenuItem[] menus = { 
                                            penToolStripMenuItem, 
                                            highlighterToolStripMenuItem, 
                                            eraserToolStripMenuItem, 
                                            SelectMenuToolStripItem, 
                                            TextToolStripMenuItem 
                                        };
            foreach (var menu in menus)
            {
                if (menu == menuItem)
                {
                    menu.Checked = true;
                }
                else
                {
                    menu.Checked = false;
                }
            }
        }

        private void picPreview_Click(object sender, EventArgs e)
        {

        }
    }
}

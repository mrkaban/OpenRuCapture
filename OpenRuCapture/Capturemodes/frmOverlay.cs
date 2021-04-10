namespace OpenRuCapture.Capturemodes
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using System.Threading;
    using System;

    public partial class frmOverlay : Form
    {
        private bool _isDrawing = false;
        private Point _endPoint = default(Point);
        private Point _starting = default(Point);
        private Common.CaptureModes _captureMode = Common.CaptureModes.Rectangle;
        private Pen _pen;
        private GraphicsPath _freeformPath;
        private int _x;
        private int _y;
        private bool _gridLines = false;

        public frmOverlay(string fileName)
            : this(fileName, Common.CaptureModes.Rectangle)
        {

        }
        public frmOverlay(string fileName, Common.CaptureModes captureMode)
        {
            InitializeComponent();
            Program.IsCaptureIsActive = true;
            CreateOverlayAllScreens();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            FileName = fileName;
            _captureMode = captureMode;
            _pen = new Pen(Color.Red, 3);
            _pen.DashStyle = DashStyle.Dash;
            switch (captureMode)
            {
                case Common.CaptureModes.Rectangle:
                    _gridLines = true;
                    break;
                case Common.CaptureModes.FreeForm:
                    _gridLines = true;
                    _freeformPath = new GraphicsPath();
                    break;
                case Common.CaptureModes.Circle:
                    break;
                case Common.CaptureModes.FixedRectangle:
                    frRectangle.Visible = true;
                    Cursor = Cursors.Default;
                    frRectangle.CaptureImage += new System.EventHandler(frRectangle_CaptureImage);
                    break;
                default:
                    break;
            }
        }

        private void frRectangle_CaptureImage(object sender, System.EventArgs e)
        {
            CaptureImage();
        }

        public string FileName
        {
            get;
            private set;
        }

        private void frmOverlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void CaptureImage()
        {
            Opacity = 0;
            switch (_captureMode)
            {
                case Common.CaptureModes.FixedRectangle:
                    var rectRegion = frRectangle.Bounds;
                    using (var bitmap = new Bitmap(rectRegion.Width, rectRegion.Height, PixelFormat.Format32bppArgb))
                    {
                        using (var graphics = Graphics.FromImage(bitmap))
                        {
                            graphics.CopyFromScreen(rectRegion.Left, rectRegion.Top, 0, 0, rectRegion.Size);
                            FileName = Common.SaveImage(bitmap);
                        }
                    }
                    break;
                case Common.CaptureModes.Rectangle:
                    var region = GetRectangle(_starting, _endPoint);
                    using (var bitmap = new Bitmap(region.Width, region.Height, PixelFormat.Format32bppArgb))
                    {
                        using (var graphics = Graphics.FromImage(bitmap))
                        {
                            graphics.CopyFromScreen(region.Left, region.Top, 0, 0, region.Size);
                            FileName = Common.SaveImage(bitmap);
                        }
                    }
                    break;
                case Common.CaptureModes.FreeForm:
                    var freeformRegion = Rectangle.Round(_freeformPath.GetBounds());
                    using (var bitmap = new Bitmap(Width, Height, PixelFormat.Format32bppArgb))
                    {
                        using (var graphics = Graphics.FromImage(bitmap))
                        {
                            graphics.CopyFromScreen(Left, Top, 0, 0, Size);
                            graphics.DrawImage(bitmap, new Point(0, 0));

                            using (Bitmap transparent = new Bitmap(bitmap))
                            {
                                using (Graphics transparentGp = Graphics.FromImage(transparent))
                                {
                                    using (Graphics originalGp = Graphics.FromImage(bitmap))
                                    {
                                        transparentGp.FillRectangle(Brushes.Pink, new Rectangle(0, 0, transparent.Width, transparent.Height));
                                        transparentGp.FillPath(Brushes.LimeGreen, _freeformPath);
                                        transparent.MakeTransparent(Color.LimeGreen);
                                        originalGp.DrawImage(transparent, new Rectangle(0, 0, transparent.Width, transparent.Height));
                                        using (Bitmap tempBitmap = new Bitmap(bitmap))
                                        {
                                            tempBitmap.MakeTransparent(Color.Pink);
                                            FileName = Common.SaveImage(Copy(tempBitmap, freeformRegion));
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case Common.CaptureModes.Circle:
                    var circleRegion = GetRectangle(_starting, _endPoint);
                    using (var bitmap = new Bitmap(circleRegion.Width, circleRegion.Height, PixelFormat.Format32bppArgb))
                    {
                        using (var graphics = Graphics.FromImage(bitmap))
                        {
                            graphics.CopyFromScreen(circleRegion.Left, circleRegion.Top, 0, 0, circleRegion.Size);
                            graphics.DrawImage(bitmap, new Point(0, 0));
                            using (Bitmap transparent = new Bitmap(bitmap))
                            {
                                using (Graphics transparentGp = Graphics.FromImage(transparent))
                                {
                                    using (Graphics originalGp = Graphics.FromImage(bitmap))
                                    {
                                        transparentGp.FillRectangle(Brushes.Pink, new Rectangle(0, 0, transparent.Width, transparent.Height));
                                        transparentGp.FillEllipse(Brushes.LimeGreen, new Rectangle(0, 0, transparent.Width, transparent.Height));
                                        transparent.MakeTransparent(Color.LimeGreen);
                                        originalGp.DrawImage(transparent, new Rectangle(0, 0, transparent.Width, transparent.Height));
                                        using (Bitmap tempBitmap = new Bitmap(bitmap))
                                        {
                                            tempBitmap.MakeTransparent(Color.Pink);
                                            FileName = Common.SaveImage(tempBitmap);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                default:
                    break;
            }

            DialogResult = DialogResult.OK;
            Program.IsCaptureIsActive = false;
            Close();
        }

        public Bitmap Copy(Bitmap srcBitmap, Rectangle section)
        {
            if (section.Width <= 0 || section.Height <= 0)
            {
                section.Width = 5;
                section.Height = 5;
            }

            Bitmap bmp = new Bitmap(section.Width, section.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
            }
            return bmp;
        }

        private void DrawShape(Graphics graphics)
        {
            switch (_captureMode)
            {
                case Common.CaptureModes.Rectangle:
                    var rect = GetRectangle(_endPoint, _starting);
                    if (_isDrawing)
                    {
                        graphics.DrawString(string.Format("Высота : {0} Ширина : {1}", rect.Width, rect.Height), Font, Brushes.Black, new Point(rect.Right + 5, rect.Bottom + 5));
                    }
                    graphics.DrawRectangle(_pen, rect);
                    break;
                case Common.CaptureModes.FreeForm:
                    graphics.DrawPath(_pen, _freeformPath);
                    break;
                case Common.CaptureModes.Circle:
                    var circleRect = GetRectangle(_endPoint, _starting);
                    if (_isDrawing)
                    {
                        graphics.DrawString(string.Format("Высота : {0} Ширина : {1}", circleRect.Width, circleRect.Height), Font, Brushes.Black, new Point(circleRect.Right + 5, circleRect.Bottom + 5));
                    }
                    graphics.DrawEllipse(_pen, circleRect);
                    break;
                default:
                    break;
            }
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            Rectangle rectangle = new Rectangle();
            if (p1.X < p2.X)
            {
                rectangle.X = p1.X;
                rectangle.Width = p2.X - p1.X;
            }
            else
            {
                rectangle.X = p2.X;
                rectangle.Width = p1.X - p2.X;
            }
            if (p1.Y < p2.Y)
            {
                rectangle.Y = p1.Y;
                rectangle.Height = p2.Y - p1.Y;
            }
            else
            {
                rectangle.Y = p2.Y;
                rectangle.Height = p1.Y - p2.Y;
            }
            return rectangle;
        }

        private void DrawLine(Point point1, Point point2)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.DrawLine(_pen, point1, point2);
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDrawing = true;
                _starting = e.Location;
                switch (_captureMode)
                {
                    case Common.CaptureModes.FreeForm:
                        _freeformPath.StartFigure();
                        break;
                }
            }
        }

        private void onMouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X;
            _y = e.Y;
            if (_isDrawing)
            {
                switch (_captureMode)
                {
                    case Common.CaptureModes.FreeForm:
                        _freeformPath.AddLine(e.X, e.Y, e.X, e.Y);
                        break;
                }
                _endPoint = e.Location;
            }
            Invalidate();
        }

        private void onPaint(object sender, PaintEventArgs e)
        {
            if (_gridLines)
            {
                e.Graphics.DrawLine(Pens.Blue, new Point(_x, 0), new Point(_x, Bottom));
                e.Graphics.DrawLine(Pens.Blue, new Point(0, _y), new Point(Right, _y));
            }
            DrawShape(e.Graphics);
        }

        private void onMouseUp(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _isDrawing = false;
                CaptureImage();
            }
        }

        private void frmOverlay_Load(object sender, System.EventArgs e)
        {
            if (_captureMode == Common.CaptureModes.FixedRectangle)
            {
                frRectangle.Left = Width / 2 - frRectangle.Width / 2;
                frRectangle.Top = Height / 2 - frRectangle.Height / 2;
            }
        }

        private void CreateOverlayAllScreens()
        {
            int h = 0;
            int w = 0;
            int x = 0;
            int y = 0;

            foreach (Screen s in Screen.AllScreens)
            {
                if (s.Bounds.X < x)
                    x = s.Bounds.X;
                if (s.Bounds.Y < y)
                    y = s.Bounds.Y;
                h += s.Bounds.Height;
                w += s.Bounds.Width;
            }

            this.Height = h;
            this.Width = w;
            this.Left = x;
            this.Top = y;
        }

        private void frRectangle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

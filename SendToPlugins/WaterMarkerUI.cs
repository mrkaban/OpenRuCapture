using System.Windows.Forms;
using System.Drawing;
using System;
using System.IO;
using OpenRuCapture.Libs;
using dotnetthoughts.OpenRuCapture;
using System.Reflection;

namespace SendToPlugins
{
    public partial class WaterMarkerUI : Form
    {
        private string _fileName;
        private WaterMarker _waterMarker;
        private string _tempFileName;
        private string _configFile;

        public WaterMarkerUI()
        {
            InitializeComponent();
        }

        public WaterMarkerUI(string fileName)
            : this()
        {
            _fileName = fileName;
            _tempFileName = Path.GetTempFileName();
            File.Copy(_fileName, _tempFileName, true);
            picWaterMarkPreview.Image = Image.FromFile(_tempFileName);
            _waterMarker = new WaterMarker();
            _waterMarker.SetImage(picWaterMarkPreview.Image);
            _waterMarker.Color = Color.Black;
            _waterMarker.Font = Font;
            _waterMarker.WatermarkText = txtWatermarkText.Text;
            ddlAlignment.DataSource = Enum.GetNames(typeof(ContentAlignment));
            //File
            try
            {
                var configFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "OpenRuCapture");
                if (!Directory.Exists(configFileName))
                {
                    Directory.CreateDirectory(configFileName);
                }
                _configFile = Path.Combine(configFileName, "WaterMarkerUI.ini");
                if (File.Exists(_configFile))
                {
                    NativeMethods nativeMethods = new NativeMethods(_configFile);
                    _waterMarker.Font = new Font(nativeMethods.IniReadValue("Settings", "Font"),
                        float.Parse(nativeMethods.IniReadValue("Settings", "FontSize")));
                    _waterMarker.Color = Color.FromName(nativeMethods.IniReadValue("Settings", "Color"));
                }
            }
            catch
            {
                Console.WriteLine("Игнорировать все исключения");
            }
        }

        private void cmdSelectColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (DialogResult.OK == colorDialog.ShowDialog(this))
                {
                    _waterMarker.Color = colorDialog.Color;
                    picWaterMarkPreview.Image = null;
                    picWaterMarkPreview.Image = _waterMarker.Apply();
                }
            }
        }

        private void cmdSelectFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (DialogResult.OK == fontDialog.ShowDialog(this))
                {
                    _waterMarker.Font = fontDialog.Font;
                    picWaterMarkPreview.Image = null;
                    picWaterMarkPreview.Image = _waterMarker.Apply();
                }
            }
        }

        private void hsAlpha_Scroll(object sender, ScrollEventArgs e)
        {
            _waterMarker.Alpha = hsAlpha.Value;
        }

        private void ddlAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (-1 != ddlAlignment.SelectedIndex)
            {
                ContentAlignment contentAlignment =
                    (ContentAlignment)Enum.Parse(typeof(ContentAlignment), ddlAlignment.SelectedItem.ToString());
                _waterMarker.TextAlignment = contentAlignment;
                picWaterMarkPreview.Image = null;
                picWaterMarkPreview.Image = _waterMarker.Apply();
            }
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            Image tempImage = _waterMarker.Apply();
            tempImage.Save(_fileName);

            NativeMethods nativeMethods = new NativeMethods(_configFile);

            nativeMethods.IniWriteValue("Settings", "Font", _waterMarker.Font.Name);
            nativeMethods.IniWriteValue("Settings", "FontSize", _waterMarker.Font.Size.ToString());
            nativeMethods.IniWriteValue("Settings", "Color", _waterMarker.Color.Name);
            nativeMethods.IniWriteValue("Settings", "Text", _waterMarker.WatermarkText);
            nativeMethods.IniWriteValue("Settings", "Alpha", _waterMarker.Alpha.ToString());
            nativeMethods.IniWriteValue("Settings", "Alignment", _waterMarker.TextAlignment.ToString());

            nativeMethods = null;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtWatermarkText_TextChanged(object sender, EventArgs e)
        {
            _waterMarker.WatermarkText = txtWatermarkText.Text;
            picWaterMarkPreview.Image = null;
            picWaterMarkPreview.Image = _waterMarker.Apply();
        }

        private void WaterMarkerUI_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}


namespace OpenRuCapture.Plugins
{
    using OpenRuCapture.Libs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

    public class SendToPrinter : ISendTo
    {
        private Image _previewImage;
        //private PluginConfiguration _configuration;

        public string Text
        {
            get { return "&Принтер"; }
        }

        private ISendToHost _host;
        public ISendToHost Host
        {
            get
            {
                return _host;
            }
            set
            {
                _host = value;
            }
        }

        public void Execute(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                return;
            }

            //if (_host != null)
            //{
            //    _configuration = _host.LoadConfiguration(Name);
            //}

            _previewImage = Image.FromFile(filename);
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument_PrintPage;

            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.ShowHelp = false;
                printDialog.ShowNetwork = false;
                printDialog.Document = printDocument;
                printDialog.AllowPrintToFile = true;
                printDialog.AllowCurrentPage = false;
                printDialog.AllowSelection = false;
                printDialog.AllowSomePages = false;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }

        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float newWidth = _previewImage.Width * 100 / _previewImage.HorizontalResolution;
            float newHeight = _previewImage.Height * 100 / _previewImage.VerticalResolution;

            float widthFactor = newWidth / e.MarginBounds.Width;
            float heightFactor = newHeight / e.MarginBounds.Height;

            if (widthFactor > 1 | heightFactor > 1)
            {
                if (widthFactor > heightFactor)
                {
                    newWidth = newWidth / widthFactor;
                    newHeight = newHeight / widthFactor;
                }
                else
                {
                    newWidth = newWidth / heightFactor;
                    newHeight = newHeight / heightFactor;
                }
            }
            e.Graphics.DrawImage(_previewImage, 0, 0, (int)newWidth, (int)newHeight);
        }
        
        public string Name
        {
            get { return this.GetType().Name; }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_previewImage != null)
            {
                _previewImage.Dispose();
                _previewImage = null;
            }
        }

        #endregion
    }
}

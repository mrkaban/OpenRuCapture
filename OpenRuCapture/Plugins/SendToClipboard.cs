namespace OpenRuCapture.Plugins
{
    using System.Drawing;
    using System.Windows.Forms;
    using OpenRuCapture.Libs;
    using System;
    using System.Collections.Generic;

    public class SendToClipboard : ISendTo
    {
        private string _fileName = string.Empty;

        public string Text
        {
            get { return "&Буфер обмена"; }
        }

        public void Execute(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                return;
            }

            _fileName = filename;
            using (var image = Image.FromFile(filename))
            {
                Clipboard.SetImage(image);
                MessageBox.Show("Изображение скопировано в буфер обмена", "OpenRuCapture", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string Name
        {
            get { return this.GetType().Name; }
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

        #region IDisposable Members

        public void Dispose()
        {

        }

        #endregion
    }

    public class SendToClipboadConfig
    {
        private bool _copyFileName;
        public bool CopyFileName
        {
            get
            {
                return _copyFileName;
            }
            set
            {
                _copyFileName = value;
            }
        }
    }
}

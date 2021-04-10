namespace OpenRuCapture.Plugins
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using OpenRuCapture.Libs;
    

    
    public class SendToMailRecipient : ISendTo
    {
        private string _fileName;

        public string Text
        {
            get { return "&Получатель почты"; }
        }

        public void Execute(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                return;
            }
            var mapi = new MAPI();
            _fileName = filename;
            mapi.AddAttachment(filename);
            mapi.SendMailPopup(string.Empty, filename);
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

    
}

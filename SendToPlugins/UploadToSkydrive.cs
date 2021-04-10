using System;
using System.Windows.Forms;
using OpenRuCapture.Libs;

namespace SendToPlugins
{
    class UploadToSkydrive : ISendTo
    {
        public string Name
        {
            get { return this.GetType().Name; }
        }

        public string Text
        {
            get { return "Skydrive"; }
        }

        public void Execute(string filename)
        {
            SendToSkydriveUI sendToSkydrive = new SendToSkydriveUI(filename);
            sendToSkydrive.ShowDialog();
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

        public void Dispose()
        {

        }
    }
}

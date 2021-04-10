namespace OpenRuCapture.Plugins
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Windows.Forms;
    using OpenRuCapture.Libs;
    

    
    public class SendToDefaultEditor : ISendTo
    {
        public string Text
        {
            get { return "Редактор по умолчанию"; }
        }

        public void Execute(string filename)
        {
            string executable = FindExecutable(filename);
            if (executable != null)
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(executable);
                processStartInfo.Arguments = filename;
                Process.Start(processStartInfo);
            }
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

        [DllImport("shell32.dll", EntryPoint = "FindExecutable")]
        public static extern long FindExecutableA(string lpFile, string lpDirectory, StringBuilder lpResult);

        public static string FindExecutable(string pv_strFilename)
        {
            StringBuilder objResultBuffer = new StringBuilder(1024);
            long lngResult = 0;

            lngResult = FindExecutableA(pv_strFilename, string.Empty, objResultBuffer);

            if (lngResult >= 32)
            {
                return objResultBuffer.ToString();
            }

            return null;
        }

        public string Name
        {
            get { return this.GetType().Name; }
        }

        #region IDisposable Members

        public void Dispose()
        {

        }

        #endregion
    }
}

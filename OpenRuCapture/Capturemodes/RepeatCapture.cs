namespace OpenRuCapture.Capturemodes
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    

    
    public class RepeatCapture : ICaptureMode
    {
        private string _folder;
        private object _owner;
        private IntPtr _windowHandle = IntPtr.Zero;

        #region ICaptureMode Members

        public string Name
        {
            get { return "RepeatCapture"; }
        }

        public string Text
        {
            get { return "Повторить последний захват"; }
        }

        //public Image Icon
        //{
        //    get { return Properties.Resources.arrow_repeat; }
        //}

        public string Description
        {
            get { return "Помогает повторить последний захват."; }
        }

        public Keys ShortcutKey
        {
            get { return Keys.Control & Keys.Z; }
        }

        public bool IsEnabled
        {
            get
            {
                return true;
                //string lastCapture = Properties.Settings.Default.LastCaptureMode;
                //return string.IsNullOrEmpty(lastCapture) && !lastCapture.Equals(this.GetType().FullName, StringComparison.CurrentCultureIgnoreCase);
            }
        }

        public void Initialize(params object[] arguments)
        {
            _folder = arguments[0].ToString();
            _owner = arguments[1].ToString();
            _windowHandle = (IntPtr)arguments[2];
        }

        public string Execute()
        {
            string lastCapture = Properties.Settings.Default.LastCaptureMode;
            if (!string.IsNullOrEmpty(lastCapture) && !lastCapture.Equals(this.GetType().FullName, StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.LastCaptureMode = null;
                Properties.Settings.Default.Save();
                return Common.ExecuteCaptureMode(lastCapture, new object[] { new object[] { _folder, _owner, _windowHandle } }).ToString();
            }
            else
            {
                return null;
            }
        }

        public bool IsFinished
        {
            get { return true; }
        }

        #endregion
    }
}

namespace OpenRuCapture.Capturemodes
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    

    
    public class WindowCapture : ICaptureMode
    {
        private string _folder;
        private object _owner;
        private IntPtr _windowHandle = IntPtr.Zero;

        public string Name
        {
            get { return "WindowCapture"; }
        }

        public string Text
        {
            get { return "Окно"; }
        }

        //public Image Icon
        //{
        //    get { return Properties.Resources.window; }
        //}

        public string Description
        {
            get { return "Помогает захватить любое окно, выбрать любое окно после нажатия этого пункта меню."; }
        }

        public Keys ShortcutKey
        {
            get { return Keys.Control & Keys.W; }
        }

        public bool IsEnabled
        {
            get { return true; }
        }

        public void Initialize(params object[] arguments)
        {
            _folder = arguments[0].ToString();
            _owner = arguments[1].ToString();
            _windowHandle = (IntPtr)arguments[2];
        }

        public string Execute()
        {
            using (frmWindowCapture frmWindowCapture = new frmWindowCapture())
            {
                if (frmWindowCapture.ShowDialog() == DialogResult.OK)
                {
                    return frmWindowCapture.FileName;
                }
            }
            return string.Empty;
        }

        public bool IsFinished
        {
            get { return false; }
        }
    }
}

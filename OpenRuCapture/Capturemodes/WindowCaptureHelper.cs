namespace OpenRuCapture.Capturemodes
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Windows.Forms;
    using dotnetthoughts.OpenRuCapture;

    class WindowCaptureHelper : ICaptureMode
    {
        private string _folder;
        private object _owner;
        private IntPtr _windowHandle = IntPtr.Zero;

        #region ICaptureMode Members

        public string Name
        {
            get { return "WindowCaptureHelper"; }
        }

        public string Text
        {
            get { throw new NotImplementedException(); }
        }

        public System.Drawing.Image Icon
        {
            get { throw new NotImplementedException(); }
        }

        public string Description
        {
            get { throw new NotImplementedException(); }
        }

        public System.Windows.Forms.Keys ShortcutKey
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsEnabled
        {
            get { return false; }
        }

        public void Initialize(params object[] arguments)
        {
            _folder = arguments[0].ToString();
            _owner = arguments[1].ToString();
            _windowHandle = (IntPtr)arguments[2];
        }

        public string Execute()
        {
            string fileName = string.Empty;
            var rect = default(NativeMethods.RECT);
            Common.RestoreIfMinimized(_windowHandle);
            if (NativeMethods.GetWindowRect(_windowHandle, ref rect))
            {
                var region = NativeMethods.ConvertToRectangle(rect);
                using (var bitmap = new Bitmap(region.Width, region.Height, PixelFormat.Format32bppArgb))
                {
                    using (var graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.CopyFromScreen(region.Left, region.Top, 0, 0, region.Size);
                        if (Properties.Settings.Default.IncludeCursor)
                        {
                            Rectangle cursorBounds = new Rectangle(Cursor.Position, Cursor.Current.Size);
                            graphics.DrawIcon(CursorHelper.GetIcon(), cursorBounds);
                        }
                        fileName = Common.SaveImage(bitmap);
                    }
                }
            }
            return fileName;
        }

        public bool IsFinished
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}

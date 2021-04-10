namespace OpenRuCapture.Capturemodes
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    

    
    public class FullScreenCapture : ICaptureMode
    {
        private string _folder;
        public string Name
        {
            get { return "FullScreenCapture"; }
        }

        public string Text
        {
            get { return "Полноэкранный"; }
        }

        //public Image Icon
        //{
        //    get { return Properties.Resources.fullscreen; }
        //}

        public string Description
        {
            get { return "Помогает захватить весь экран."; }
        }

        public Keys ShortcutKey
        {
            get { return Keys.Control & Keys.F11; }
        }

        public void Initialize(params object[] arguments)
        {
            _folder = arguments[0].ToString();
        }

        public string Execute()
        {
            int width = 0;
            int height = 0;
            int minx = 0;
            int miny = 0;

            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                Screen z = Screen.AllScreens[i];
                if (z.Bounds.X < minx) minx = z.Bounds.X;
                if (z.Bounds.Y < miny) miny = z.Bounds.Y;
                if (i == 0)
                {
                    width = z.Bounds.Width;
                    height = z.Bounds.Height;
                }
                else
                {
                    Screen p = Screen.AllScreens[i - 1];
                    if (z.Bounds.Right > p.Bounds.Right)
                    {
                        width += z.Bounds.Right - p.Bounds.Right;
                    }
                    else
                    {
                        if (z.Bounds.Left < p.Bounds.Left)
                        {
                            width += Math.Abs(p.Bounds.Left - z.Bounds.Left);
                        }
                    }
                    if (z.Bounds.Top < p.Bounds.Top)
                    {
                        height += (Math.Abs(z.Bounds.Top) - Math.Abs(z.Bounds.Bottom));
                    }
                    else
                    {
                        if (z.Bounds.Bottom > p.Bounds.Bottom)
                        {
                            height += z.Bounds.Bottom - p.Bounds.Bottom;
                        }
                    }
                }
            }

            using (Bitmap bitmap = new Bitmap(width, height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap as Image))
                {
                    for (int i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        Screen x = Screen.AllScreens[i];
                        graphics.CopyFromScreen(x.Bounds.X, x.Bounds.Y, x.Bounds.X + (Math.Abs(minx)),
                             x.Bounds.Y + Math.Abs(miny), x.Bounds.Size);
                    }

                    return Common.SaveImage(bitmap);
                }
            }
        }

        public bool IsEnabled
        {
            get { return true; }
        }

        public bool IsFinished
        {
            get { return true; }
        }
    }
}

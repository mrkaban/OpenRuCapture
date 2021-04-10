using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using dotnetthoughts.OpenRuCapture;

namespace OpenRuCapture.Capturemodes
{
    public partial class frmWindowCapture : Form
    {
        private bool _isCaptured;
        private IntPtr _lastWindow;
        public frmWindowCapture()
        {
            InitializeComponent();
        }
        public string FileName { private set; get; }

        private void picFinder_Click(object sender, EventArgs e)
        {
            CaptureMouse(true);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case (int)NativeMethods.WM_LBUTTONUP:
                    CaptureWindow();
                    CaptureMouse(false);
                    CloseWindow();
                    break;
                case (int)NativeMethods.WM_MOUSEMOVE:
                    HandleMouseMoves();
                    break;
            }
            base.WndProc(ref m);
        }

        private void CloseWindow()
        {
            if (_isCaptured)
            {
                NativeMethods.ReleaseCapture();
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CaptureWindow()
        {
            var handle = NativeMethods.WindowFromPoint(Cursor.Position);
            if (handle != IntPtr.Zero)
            {
                _lastWindow = handle;
                NativeMethods.SetForegroundWindow(handle);
                Opacity = 0;
                var rect = new NativeMethods.RECT();
                NativeMethods.GetWindowRect(handle, ref rect);

                var region = NativeMethods.ConvertToRectangle(rect);
                using (var bitmap = new Bitmap(region.Width, region.Height, PixelFormat.Format32bppArgb))
                {
                    using (var graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.CopyFromScreen(region.Left, region.Top, 0, 0, region.Size);
                        FileName = Common.SaveImage(bitmap);
                    }
                }
            }
        }

        private void HandleMouseMoves()
        {
            if (!_isCaptured)
            {
                return;
            }

            var handle = NativeMethods.WindowFromPoint(Cursor.Position);
            if (_lastWindow != IntPtr.Zero && _lastWindow != handle)
            {
                ResetWindow(_lastWindow);
            }

            if (handle != IntPtr.Zero)
            {
                _lastWindow = handle;
                var rect = new NativeMethods.RECT();
                NativeMethods.GetWindowRect(handle, ref rect);
                lblWindowName.Text = NativeMethods.GetWindowTitle(handle);
                var hdc = NativeMethods.GetWindowDC(handle);
                if (hdc != IntPtr.Zero)
                {
                    using (var pen = new Pen(Color.Red, 3))
                    {
                        using (var graphics = Graphics.FromHdc(hdc))
                        {
                            graphics.DrawRectangle(pen, 0, 0, rect.right - rect.left - 3, rect.bottom - rect.top - 3);
                        }
                    }
                }
                NativeMethods.ReleaseDC(handle, hdc);
            }
        }

        private void CaptureMouse(bool capture)
        {
            if (capture)
            {
                NativeMethods.SetCapture(Handle);
                Cursor = NativeMethods.CreateCursor(new Bitmap(picFinder.Image), 5, 5);
            }
            else
            {
                NativeMethods.ReleaseCapture();
                if (_lastWindow != IntPtr.Zero)
                {
                    ResetWindow(_lastWindow);
                    _lastWindow = IntPtr.Zero;
                }
                Cursor = Cursors.Default;
            }
            _isCaptured = capture;
        }

        private void ResetWindow(IntPtr handle)
        {
            NativeMethods.InvalidateRect(handle, IntPtr.Zero, 1);
            NativeMethods.UpdateWindow(handle);
            NativeMethods.RedrawWindow(handle, IntPtr.Zero, IntPtr.Zero,
                NativeMethods.RDW_FRAME | NativeMethods.RDW_INVALIDATE | NativeMethods.RDW_UPDATENOW | NativeMethods.RDW_ALLCHILDREN);
        }

        private void picFinder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CaptureMouse(true);
            }
        }

        private void frmWindowCapture_Load(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.Bounds.Height - Height -10;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 10;
        }

        private void picFinder_Click_1(object sender, EventArgs e)
        {

        }
    }
}

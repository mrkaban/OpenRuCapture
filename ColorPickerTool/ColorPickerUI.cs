using System;
using System.Drawing;
using System.Windows.Forms;
using dotnetthoughts.OpenRuCapture;

namespace ColorPickerTool
{
    public partial class ColorPickerUI : Form
    {
        private bool _isCaptured;
        private ColorConverter _colorConverter;

        public ColorPickerUI()
        {
            InitializeComponent();
            NativeMethods.SetWindowPos(Handle, NativeMethods.HWND_TOPMOST, 0, 0, 0, 0, NativeMethods.TOPMOST_FLAGS);
            _colorConverter = new ColorConverter();
            Left = Screen.PrimaryScreen.WorkingArea.Right - Width;
            Top = Screen.PrimaryScreen.WorkingArea.Bottom - Height;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case (int)NativeMethods.WM_LBUTTONUP:
                    CaptureMouse(false);
                    break;
                case (int)NativeMethods.WM_MOUSEMOVE:
                    HandleMouseMoves();
                    break;
            }
            base.WndProc(ref m);
        }

        private void HandleMouseMoves()
        {
            if (!_isCaptured)
            {
                return;
            }
            Color color = NativeMethods.GetPixelColor();
            picPreview.BackColor = color;
            txtHex.Text = ColorTranslator.ToHtml(color);
            txtRgb.Text = _colorConverter.ConvertToString(color);
        }

        private void picColorChooser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CaptureMouse(true);
            }
        }

        private void CaptureMouse(bool capture)
        {
            if (capture)
            {
                NativeMethods.SetCapture(Handle);
                Cursor = Cursors.Cross;
            }
            else
            {
                NativeMethods.ReleaseCapture();
                Cursor = Cursors.Default;
            }
            _isCaptured = capture;
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHex.Text))
                Clipboard.SetText(txtHex.Text);
        }
    }
}

namespace OpenRuCapture.Capturemodes
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    class FixedRegion : Panel
    {
        private const int HTBOTTOMRIGHT = 17;
        private const int WM_NCHITTEST = 0x84;
        private const int WM_SIZE = 0x05;
        private int _x;
        private int _y;
        public event EventHandler CaptureImage;

        public FixedRegion()
        {
            MouseDoubleClick += new MouseEventHandler(FixedRegion_MouseDoubleClick);
            MouseDown += new MouseEventHandler(FixedRegion_MouseDown);
            MouseMove += new MouseEventHandler(FixedRegion_MouseMove);
            MouseUp += new MouseEventHandler(FixedRegion_MouseUp);
            BackColor = Color.SkyBlue;
        }

        void FixedRegion_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }

        void FixedRegion_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left = (Left + e.X) - _x;
                Top = (Top + e.Y) - _y;
            }
        }

        void FixedRegion_MouseDown(object sender, MouseEventArgs e)
        {
            _x = e.X;
            _y = e.Y;
            Cursor = Cursors.Hand;
        }

        void FixedRegion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CaptureImage != null)
            {
                CaptureImage(this, e);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Dashed);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, Width - 16, Height - 16, 16, 16);
            var info = string.Format("Ширина : {0} Высота : {1}", Width, Height);
            var size = Size.Round(e.Graphics.MeasureString(info, Font));
            ControlPaint.DrawStringDisabled(e.Graphics, info, Font, Color.Red, new Rectangle(new Point(4, 4), size), StringFormat.GenericDefault);
            base.OnPaint(e);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_SIZE:
                    Invalidate();
                    break;
                case WM_NCHITTEST:
                    Point p = FindForm().PointToClient(new Point((int)m.LParam));
                    int x = p.X;
                    int y = p.Y;
                    Rectangle rect = Bounds;
                    if (x >= rect.X + rect.Width - 12 &&
                        x <= rect.X + rect.Width &&
                        y >= rect.Y + rect.Height - 12 &&
                        y <= rect.Y + rect.Height)
                    {
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                        return;
                    }
                    break;
            }
            base.WndProc(ref m);
        }
    }
}

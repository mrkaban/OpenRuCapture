namespace OpenRuCapture.Capturemodes
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    class CursorHelper
    {
        [StructLayout(LayoutKind.Sequential)]
        struct POINT
        {
            public Int32 x;
            public Int32 y;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct CURSORINFO
        {
            public Int32 cbSize;
            public Int32 flags;
            public IntPtr hCursor;
            public POINT ptScreenPos;
        }

        [DllImport("user32.dll")]
        static extern bool GetCursorInfo(out CURSORINFO pci);

        private const Int32 CURSOR_SHOWING = 0x00000001;

        public static Icon GetIcon()
        {
            Icon icon = null;
            CURSORINFO cursorinfo;
            cursorinfo.cbSize = Marshal.SizeOf(typeof(CURSORINFO));
            GetCursorInfo(out cursorinfo);
            if (cursorinfo.flags == CURSOR_SHOWING)
            {
                icon = Icon.FromHandle(cursorinfo.hCursor);
            }
            return icon;
        }
    }
}

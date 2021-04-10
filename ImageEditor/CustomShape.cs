using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageEditor
{
    internal class CustomShape
    {
        private Shape _shape;
        private GraphicsPath _path;
        private Pen _pen;

        public Shape Shape
        {
            get { return _shape; }
            set { _shape = value; }
        }

        public GraphicsPath Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public Pen Pen
        {
            get { return _pen; }
            set { _pen = value; }
        }
    }

    internal enum Shape
    {
        Unknown = 0, Pen = 1, Highlighter = 2, Eraser = 3, Text = 4, Selection = 5
    }

    internal enum PenSize
    {
        Fine = 3, Medium = 8, Thick = 15
    }
}

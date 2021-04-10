
namespace SendToPlugins
{
    using System.ComponentModel;
    using System.Drawing;

    /// <summary>
    /// </summary>
    public class WaterMarker
    {
        private Image _selectedImage;
        private Color _color;
        private Font _font;
        private int _alpha;
        private string _watermarkText;
        private ContentAlignment _textAlignment;

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public Font Font
        {
            get
            {
                return _font;
            }
            set
            {
                _font = value;
            }
        }

        public int Alpha
        {
            get
            {
                return _alpha;
            }
            set
            {
                _alpha = value;
            }
        }

        public string WatermarkText
        {
            get
            {
                return _watermarkText;
            }
            set
            {
                _watermarkText = value;
            }
        }

        public ContentAlignment TextAlignment
        {
            get
            {
                return _textAlignment;
            }
            set
            {
                _textAlignment = value;
            }
        }

        [Category("Display"), Description("Изображение выбрано"), Browsable(false)]
        public Image SelectedImage
        {
            get
            {
                return _selectedImage;
            }
        }

        public void SetImage(Image image)
        {
            _selectedImage = image;
        }

        /// <summary>
        /// Creates an instance of Watermarker class.
        /// </summary>
        public WaterMarker()
        {
            Color = Color.Black;
            Alpha = 200;
            Font = new Font(FontFamily.GenericSerif, 20);
            WatermarkText = "OpenRuCapture";
            TextAlignment = ContentAlignment.BottomCenter;
        }

        /// <summary>
        /// Adds the watermark text to the given image.
        /// </summary>
        /// <param name="image">Image to apply watermark</param>
        /// <param name="waterMarkText">Watermark Text</param>
        /// <returns>Image</returns>
        public Image Apply(Image image, string waterMarkText)
        {
            WatermarkText = waterMarkText;
            using (Graphics graphics = Graphics.FromImage(image))
            {
                var size =
                    graphics.MeasureString(WatermarkText, Font);
                var brush =
                    new SolidBrush(Color.FromArgb(Alpha, Color));
                graphics.DrawString
                    (WatermarkText, Font, brush,
                    GetTextPosition(image, size));
            }
            return image;
        }

        /// <summary>
        /// Adds the watermark text to the given image.
        /// </summary>
        /// <param name="image">Image to apply watermark</param>
        /// <returns>Image</returns>
        public Image Apply(Image image)
        {
            return Apply(image, WatermarkText);
        }

        public Image Apply()
        {
            Image imageCopy = _selectedImage.Clone() as Image;
            return Apply(imageCopy);
        }

        private PointF GetTextPosition(Image image, SizeF size)
        {
            PointF point = default(PointF);
            switch (TextAlignment)
            {
                case ContentAlignment.BottomCenter:
                    point = new PointF((image.Width - size.Width) / 2,
                        (image.Height - size.Height));
                    break;
                case ContentAlignment.BottomLeft:
                    point = new PointF(0, (image.Height - size.Height));
                    break;
                case ContentAlignment.BottomRight:
                    point = new PointF((image.Width - size.Width),
                        (image.Height - size.Height));
                    break;
                case ContentAlignment.MiddleCenter:
                    point = new PointF((image.Width - size.Width) / 2,
                        (image.Height - size.Height) / 2);
                    break;
                case ContentAlignment.MiddleLeft:
                    point = new PointF(0, (image.Height - size.Height) / 2);
                    break;
                case ContentAlignment.MiddleRight:
                    point = new PointF((image.Width - size.Width),
                        (image.Height - size.Height) / 2);
                    break;
                case ContentAlignment.TopCenter:
                    point = new PointF((image.Width - size.Width) / 2, 0);
                    break;
                case ContentAlignment.TopLeft:
                    point = new PointF(0, 0);
                    break;
                case ContentAlignment.TopRight:
                    point = new PointF((image.Width - size.Width), 0);
                    break;
            }
            return point;
        }
    }
}

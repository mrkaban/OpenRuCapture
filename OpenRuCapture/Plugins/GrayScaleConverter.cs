using System;
using System.Collections.Generic;
using System.Text;
using OpenRuCapture.Libs;
using System.Windows.Forms;
using System.Drawing;


namespace OpenRuCapture.Plugins
{
    
    public class GrayScaleConverter : ISendTo
    {
        #region ISendTo Members

        public string Name
        {
            get { return this.GetType().Name; }
        }

        public string Text
        {
            get { return "Конвертер серого цвета"; }
        }

        public void Execute(string filename)
        {
            if (MessageBox.Show(string.Format("Это создаст копию изображения и преобразует изображение в оттенки серого.{0}{0}Продолжить?", Environment.NewLine),
                Constants.APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (Bitmap bitmap = Bitmap.FromFile(filename) as Bitmap)
                {
                    using (Bitmap bmp = ConvertToGrayscale(bitmap))
                    {
                        Common.SaveImage(bmp, filename);
                        MessageBox.Show("Изображение, преобразованное в оттенки серого", Constants.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private Bitmap ConvertToGrayscale(Bitmap source)
        {
            Bitmap bm = new Bitmap(source.Width, source.Height);
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    Color c = source.GetPixel(x, y);
                    int luma = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    bm.SetPixel(x, y, Color.FromArgb(luma, luma, luma));
                }
            }
            return bm;
        }

                private ISendToHost _host;
        public ISendToHost Host
        {
            get
            {
                return _host;
            }
            set
            {
                _host = value;
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        #endregion
    }
}

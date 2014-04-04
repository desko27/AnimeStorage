using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;

namespace AnimeStorage
{
    class Utils
    {
        public static Bitmap CreateSquareThumbnail(Image img, int side)
        {
            System.Drawing.Bitmap bmpOut = null;
            try {

                Bitmap bmp = new Bitmap(img);
                bmpOut = new Bitmap(side, side);
                Graphics g = Graphics.FromImage(bmpOut);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.FillRectangle(Brushes.White, 0, 0, side, side);
                g.DrawImage(bmp, 0, 0, side, side);

                bmp.Dispose();
            
            } catch { return null; }
            return bmpOut;
        }
    }
}

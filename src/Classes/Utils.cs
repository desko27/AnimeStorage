using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Diagnostics;

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

        public static XDocument GetCachedXmlFile(String filepath, int days, String httprequest)
        {
            XDocument doc = null;

            // check for cached xml
            if (File.Exists(filepath))
            {
                // get file info & check if it's not expired
                FileInfo fileinfo = new FileInfo(filepath);
                if ((DateTime.Now - fileinfo.LastWriteTime).TotalDays < days)
                {

                    // not expired - load cached local document
                    doc = XDocument.Load(filepath);
                }
            }

            // if not cached or expired, get xml from api and save it to cache
            if (doc == null)
            {
                try
                {
                    HttpWebRequest request = WebRequest.Create(httprequest) as HttpWebRequest;
                    request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    doc = XDocument.Load(response.GetResponseStream());
                    doc.Save(filepath);
                }
                catch (Exception e)
                {
                    // could not load api request?
                    Debug.WriteLine("Could not load API request: " + e.Message);
                }
            }

            return doc;
        }
    }
}

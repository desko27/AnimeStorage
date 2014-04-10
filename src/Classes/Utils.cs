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

        public static List<Tuple<int, string, int>> GetSimilarTitles(string input, Dictionary<int, AnimeTitle> animeTitles, int range)
        {
            List<Tuple<int, string, int>> similars = new List<Tuple<int, string, int>>();
            foreach (var title_object in animeTitles)
            {
                String[] title_versions = new String[] { title_object.Value.XJatName, title_object.Value.EnglishName };
                foreach (var title in title_versions)
                {

                    if (title == "") continue;
                    var distance = Utils.Levenshtein(input, title);
                    var tuple = Tuple.Create(title_object.Key, title, distance);

                    //Debug.WriteLine(distance + " : " + title);

                    if (similars.Count > 0)
                    {
                        for (int i = 0; i < similars.Count; i++)
                        {
                            // better distance
                            if (distance <= similars[i].Item3)
                            {
                                if (i + 1 == similars.Count)
                                {
                                    if (!similars.Contains(tuple)) similars.Add(tuple);
                                    break;
                                }
                                else
                                    continue;
                            }
                            else if (i == 0)
                            {
                                if (similars.Count >= range) break;
                                else
                                    if (!similars.Contains(tuple)) similars.Insert(0, tuple);
                            }
                            else
                            {
                                if (!similars.Contains(tuple)) similars.Insert(i - 1, tuple);
                                break;
                            }
                        }
                        if (similars.Count > range) similars.RemoveAt(0);
                    }
                    else
                        // add the first one
                        similars.Add(tuple);

                }
            }

            similars.Reverse();
            return similars;
        }

        ///*****************************
        /// Compute Levenshtein distance 
        /// Memory efficient version
        ///*****************************
        public static int Levenshtein(String sRow, String sCol)
        {
            int RowLen = sRow.Length;  // length of sRow
            int ColLen = sCol.Length;  // length of sCol
            int RowIdx;                // iterates through sRow
            int ColIdx;                // iterates through sCol
            char Row_i;                // ith character of sRow
            char Col_j;                // jth character of sCol
            int cost;                   // cost

            /// Test string length
            if (Math.Max(sRow.Length, sCol.Length) > Math.Pow(2, 31))
                throw (new Exception("\nMaximum string length in Levenshtein.iLD is " + Math.Pow(2, 31) + ".\nYours is " + Math.Max(sRow.Length, sCol.Length) + "."));

            // Step 1

            if (RowLen == 0)
            {
                return ColLen;
            }

            if (ColLen == 0)
            {
                return RowLen;
            }

            /// Create the two vectors
            int[] v0 = new int[RowLen + 1];
            int[] v1 = new int[RowLen + 1];
            int[] vTmp;



            /// Step 2
            /// Initialize the first vector
            for (RowIdx = 1; RowIdx <= RowLen; RowIdx++)
            {
                v0[RowIdx] = RowIdx;
            }

            // Step 3

            /// Fore each column
            for (ColIdx = 1; ColIdx <= ColLen; ColIdx++)
            {
                /// Set the 0'th element to the column number
                v1[0] = ColIdx;

                Col_j = sCol[ColIdx - 1];


                // Step 4

                /// Fore each row
                for (RowIdx = 1; RowIdx <= RowLen; RowIdx++)
                {
                    Row_i = sRow[RowIdx - 1];


                    // Step 5

                    if (Row_i == Col_j)
                    {
                        cost = 0;
                    }
                    else
                    {
                        cost = 1;
                    }

                    // Step 6

                    /// Find minimum
                    int m_min = v0[RowIdx] + 1;
                    int b = v1[RowIdx - 1] + 1;
                    int c = v0[RowIdx - 1] + cost;

                    if (b < m_min)
                    {
                        m_min = b;
                    }
                    if (c < m_min)
                    {
                        m_min = c;
                    }

                    v1[RowIdx] = m_min;
                }

                /// Swap the vectors
                vTmp = v0;
                v0 = v1;
                v1 = vTmp;

            }


            // Step 7

            /// Value between 0 - 100
            /// 0==perfect match 100==totaly different
            /// 
            /// The vectors where swaped one last time at the end of the last loop,
            /// that is why the result is now in v0 rather than in v1
            //System.Console.WriteLine("iDist=" + v0[RowLen]);
            int max = System.Math.Max(RowLen, ColLen);
            return ((100 * v0[RowLen]) / max);
        }

    }
}

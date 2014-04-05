using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Net;
using System.Diagnostics;
using System.Drawing;

namespace AnimeStorage
{
    class ApiRequest
    {
        /// <summary>
        /// Must register a client
        /// http://anidb.net/perl-bin/animedb.pl?show=client
        /// </summary>
        public const string CLIENT =                "animestoragex",
                            CLIENTVER =             "1",
                            FILE_XML_STRING =       "Cache\\{0}.xml",
                            HTTP_XML_STRING =       "http://api.anidb.net:9001/httpapi?request=anime&client={0}&clientver={1}&protover=1&aid={2}",
                            IMAGE_FILE_STRING =     "Cache\\{0}.jpg",
                            IMAGE_HTTP_STRING =     "http://img7.anidb.net/pics/anime/{0}";

        static public AnimeClass Anime(int id)
        {

            // set variables
            XDocument doc = null;
            string cachedXml = String.Format(FILE_XML_STRING, id),
                   cachedImage = String.Format(IMAGE_FILE_STRING, id);

            // check for cached xml
            if (File.Exists(cachedXml))
            {
                // get file info & check if it's not expired
                FileInfo fileinfo = new FileInfo(cachedXml);
                if ((DateTime.Now - fileinfo.LastWriteTime).TotalDays < 1) {

                    // not expired - load cached local document
                    doc = XDocument.Load(cachedXml);
                }
            }

            // if not cached or expired, get xml from api and save it to cache
            if (doc == null)
            {
                try
                {
                    HttpWebRequest request = WebRequest.Create(String.Format(HTTP_XML_STRING, CLIENT, CLIENTVER, id)) as HttpWebRequest;
                    request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    doc = XDocument.Load(response.GetResponseStream());
                    doc.Save(cachedXml);
                }
                catch (Exception e)
                {
                    // could not load api request?
                    Debug.WriteLine("Could not load API request: " + e.Message);
                    return null;
                }
            }

            // explore the xml (& save/cache image)
            var xmlAnime = (from p in doc.Root.Elements() select p);

            String xjatname = "",
                    ename = "",
                    jname = "",
                    picture = null;
            int episodecount = -1,
                year = -1;
            List<double> ratings = new List<double>();

            if (doc.Root.Name == "anime")
            {
                foreach (var element in xmlAnime)
                {
                    switch (element.Name.ToString())
                    {
                        case "titles":
                            // iterate over titles and get xjat & japanese
                            foreach (var title in element.Elements())
                            {
                                foreach (var attr in title.Attributes())
                                {
                                    if ((title.Attribute("type").Value == "official" || title.Attribute("type").Value == "main") && attr.Name == XNamespace.Xml + "lang" && attr.Value == "x-jat")
                                        xjatname = title.Value;
                                    if (attr.Name == XNamespace.Xml + "lang" && attr.Value == "ja")
                                        jname = title.Value;
                                    if (title.Attribute("type").Value == "official" && attr.Name == XNamespace.Xml + "lang" && attr.Value == "en")
                                        ename = title.Value;
                                }
                            }
                            break;

                        case "startdate":
                            year = Convert.ToInt16(element.Value.Split('-')[0]);
                            break;

                        case "ratings":
                            foreach (var web_rating in element.Elements())
                                ratings.Add(Convert.ToDouble(web_rating.Value.Replace('.', ',')));
                            break;

                        case "episodecount":
                            episodecount = Convert.ToInt16(element.Value);
                            break;

                        case "picture":
                            picture = element.Value;
                            break;

                    }
                }

                // save image
                bool download_image = false;
                if (File.Exists(cachedImage))
                {
                    FileInfo fileinfo = new FileInfo(cachedImage);
                    if ((DateTime.Now - fileinfo.LastWriteTime).TotalDays >= 1)
                        download_image = true;
                }
                else
                    download_image = true;

                if (download_image)
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(String.Format(IMAGE_HTTP_STRING, picture), cachedImage);
                }

            }
            else
            {
                // error -> no anime found with this id
                return null;
            }

            // get cache image
            Bitmap bitmap;
            using (Stream BitmapStream = System.IO.File.Open(cachedImage, System.IO.FileMode.Open))
            {
                 Image img = Image.FromStream(BitmapStream);
                 bitmap = new Bitmap(img);
            }
            
            // return data -> AnimeClass object

            AnimeClass anime = new AnimeClass(null, id, bitmap, xjatname, year, ratings.Average(), jname);
            return anime;

        }

    }
}

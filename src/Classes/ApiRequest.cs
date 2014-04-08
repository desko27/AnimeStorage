using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Net;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;

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
            string cachedXml = String.Format(FILE_XML_STRING, id),
                   cachedImage = String.Format(IMAGE_FILE_STRING, id);

            // get xml file, http request if expired
            XDocument doc = Utils.GetCachedXmlFile(cachedXml, 1, String.Format(HTTP_XML_STRING, CLIENT, CLIENTVER, id));
            
            // explore the xml (& save/cache image)
            var xmlAnime = (from p in doc.Root.Elements() select p);

            bool has_enddate = false;
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
                                    if ((title.Attribute("type").Value == "official" || title.Attribute("type").Value == "synonym") && attr.Name == XNamespace.Xml + "lang" && attr.Value == "ja")
                                        if (Regex.IsMatch(title.Value, "[^\x00-\x80]+")) jname = title.Value; // must include japanese characters
                                    if (title.Attribute("type").Value == "official" && attr.Name == XNamespace.Xml + "lang" && attr.Value == "en")
                                        ename = title.Value;
                                }
                            }
                            break;

                        case "startdate":
                            year = Convert.ToInt16(element.Value.Split('-')[0]);
                            break;

                        case "enddate":
                            has_enddate = true;
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

            AnimeClass anime = new AnimeClass(null, id, bitmap, xjatname, year, has_enddate ? episodecount : -1, ratings.Average(), jname);
            return anime;

        }

    }
}

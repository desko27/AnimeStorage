using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace AnimeStorage
{

    public class AnimeClass
    {

        private MainForm mainForm;
        public String Name, Japanese;
        public double Rating = 0;
        public int ID, Year, Episodes;
        public Image Icon, Picture, ThumbnailPicture;
        public List<AnimeItem> Items = new List<AnimeItem>();

        public AnimeClass(MainForm mainForm, int ID, Image Picture, String Name, int Year, int Episodes, double Rating, String Japanese)
        {
            this.mainForm = mainForm;
            this.ID = ID;
            this.Picture = Picture;
            this.Name = Name;
            this.Year = Year;
            this.Episodes = Episodes;
            this.Rating = Rating;
            this.Japanese = Japanese;

            // don't set thumbnail when object is used as data container
            if (mainForm != null) setThumbnailPicture();
        }

        public String EmptyString { get { return ""; } }
        public String YearAspect { get { return Year == -1 ? "" : Year.ToString(); } }
        public String EpisodesAspect { get { return Episodes == -1 ? "On Air" : Episodes.ToString() + " episodes"; } }
        public String Fansub { get { return Items.Count == 1 ? Items.First().Fansub : (Items.Count == 0 ? "None" : String.Format("{0} fansubs", Items.Count)); } }
        public Image PictureAspect { get { return ThumbnailPicture == null ? null : ThumbnailPicture; } }

        public void setThumbnailPicture() {
            if (Picture == null) ThumbnailPicture = null;
            else ThumbnailPicture = Utils.CreateSquareThumbnail(Picture, mainForm.cPicture.Width);
        }
        
    }

    public class AnimeItem
    {
        public AnimeClass Parent;
        public String Lang, Fansub, Path;
        public Image LangIcon;// = ResourcesInterface.rating;

        public AnimeItem(AnimeClass Parent, String Lang, String Fansub, String Path)
        {
            this.Parent = Parent;
            this.Lang = Lang;
            this.Fansub = Fansub;
            this.Path = Path;
        }

        public String EmptyString { get { return ""; } }
        public String Name { get { return ""; } }
        public String YearAspect { get { return ""/*Lang*/; } }
        public byte Rating { get { return 0; } }
        public String Japanese { get { return ""/*Path*/; } }
        public Image Icon { get { return LangIcon; } }
    }

    /// <summary>
    /// Directly taken from 'anime-titles.xml' file.
    /// </summary>
    public class AnimeTitle
    {
        public int Id;
        public String XJatName, EnglishName, JapaneseName;

        public AnimeTitle(int Id, String XJatName, String EnglishName, String JapaneseName)
        {
            this.Id = Id;
            this.XJatName = XJatName;
            this.EnglishName = EnglishName;
            this.JapaneseName = JapaneseName;
        }
    }

}

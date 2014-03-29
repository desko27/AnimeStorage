using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimeStorage
{

    public class AnimeClass
    {
        public String Name, Japanese;
        public double Rating = 0;
        public int AniDBId, Year;
        public Image AnimeIcon;
        public List<AnimeItem> Items = new List<AnimeItem>();

        public AnimeClass(String Name, int Year, double Rating, String Japanese)
        {
            this.Name = Name;
            this.Year = Year;
            this.Rating = Rating;
            this.Japanese = Japanese;
        }

        public String YearAspect { get { return Year == -1 ? "" : Year.ToString(); } }
        
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

        public String Name { get { return Fansub; } }
        public String YearAspect { get { return ""/*Lang*/; } }
        public byte Rating { get { return 0; } }
        public String Japanese { get { return ""/*Path*/; } }
        public Image AnimeIcon { get { return LangIcon; } }
    }

    /// <summary>
    /// Directly taken from 'anime-titles.xml' file.
    /// </summary>
    public class AnimeTitle
    {
        public int Id;
        public String Name, EnglishName, JapaneseName;

        public AnimeTitle(int Id, String Name, String EnglishName, String JapaneseName)
        {
            this.Id = Id;
            this.Name = Name;
            this.EnglishName = EnglishName;
            this.JapaneseName = JapaneseName;
        }
    }

}

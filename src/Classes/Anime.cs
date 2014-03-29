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
        public String Year { get { return ""/*Lang*/; } }
        public byte Rating { get { return 0; } }
        public String Japanese { get { return ""/*Path*/; } }
        public Image AnimeIcon { get { return LangIcon; } }
    }

}

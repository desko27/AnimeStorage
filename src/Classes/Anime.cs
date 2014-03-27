using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimeStorage
{

    public class AnimeClass
    {
        public String Name, Japanese;
        public byte Rating = 0;
        public int Year = -1;
        public List<AnimeItem> Items = new List<AnimeItem>();

        public AnimeClass(String Name, int Year, byte Rating, String Japanese)
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

        public AnimeItem(AnimeClass Parent, String Lang, String Fansub, String Path)
        {
            this.Parent = Parent;
            this.Lang = Lang;
            this.Fansub = Fansub;
            this.Path = Path;
        }

        public String Name { get { return Fansub; } }
        public String Year { get { return Lang; } }
        public byte Rating { get { return 0; } }
        public String Japanese { get { return Path; } }
    }

}

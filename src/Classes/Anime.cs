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
        public List<AnimeItem> Items;

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
        public string Path, Fansub;
    }

}

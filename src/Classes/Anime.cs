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
        public List<AnimeItem> Items;

        public AnimeClass(String Name, String Japanese, byte Rating)
        {
            this.Name = Name;
            this.Japanese = Japanese;
            this.Rating = Rating;
        }
        
    }

    public class AnimeItem
    {
        public string Path, Fansub;
    }

}

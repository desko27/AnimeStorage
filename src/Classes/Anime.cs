using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimeStorage
{

    public class AnimeClass
    {
        public string Name;
        public byte Rating = 0;
        public List<AnimeItem> Items;
        
        public AnimeClass(string Name, byte Rating)
        {
            this.Name = Name;
            this.Rating = Rating;
        }
        
    }

    public class AnimeItem
    {
        public string Path, Fansub;
    }

}

using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Favourites
    {
        public int FavId { get; set; }
        public int FavBy { get; set; }
        public int User { get; set; }
        public string FavTime { get; set; }
    }
}

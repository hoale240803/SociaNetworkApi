using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Bookmarks
    {
        public int BkmrkId { get; set; }
        public int BkmrkBy { get; set; }
        public int PostId { get; set; }
        public string BkmrkTime { get; set; }
    }
}

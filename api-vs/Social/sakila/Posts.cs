using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Posts
    {
        public int PostId { get; set; }
        public int User { get; set; }
        public string Description { get; set; }
        public string ImgSrc { get; set; }
        public string Filter { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public int GroupId { get; set; }
        public string PostTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsVideos
    {
        public int VideoId { get; set; }
        public int PostId { get; set; }
        public string Source { get; set; }
        public string Thumbnail { get; set; }
        public int Views { get; set; }
    }
}

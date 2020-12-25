using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsVideo
    {
        public uint VideoId { get; set; }
        public uint PostId { get; set; }
        public string Source { get; set; }
        public string Thumbnail { get; set; }
        public int Views { get; set; }
    }
}

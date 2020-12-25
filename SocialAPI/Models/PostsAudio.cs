using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsAudio
    {
        public uint AudioId { get; set; }
        public uint PostId { get; set; }
        public string Source { get; set; }
        public int Views { get; set; }
    }
}

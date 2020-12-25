using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsFile
    {
        public uint FileId { get; set; }
        public uint PostId { get; set; }
        public string Source { get; set; }
    }
}

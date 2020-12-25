using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsLink
    {
        public uint LinkId { get; set; }
        public uint PostId { get; set; }
        public string SourceUrl { get; set; }
        public string SourceHost { get; set; }
        public string SourceTitle { get; set; }
        public string SourceText { get; set; }
        public string SourceThumbnail { get; set; }
    }
}

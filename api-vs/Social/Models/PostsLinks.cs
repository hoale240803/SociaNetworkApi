using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsLinks
    {
        public int LinkId { get; set; }
        public int PostId { get; set; }
        public string SourceUrl { get; set; }
        public string SourceHost { get; set; }
        public string SourceTitle { get; set; }
        public string SourceText { get; set; }
        public string SourceThumbnail { get; set; }
    }
}

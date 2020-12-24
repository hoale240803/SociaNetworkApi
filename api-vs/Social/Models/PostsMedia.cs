using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsMedia
    {
        public int MediaId { get; set; }
        public int PostId { get; set; }
        public string SourceUrl { get; set; }
        public string SourceProvider { get; set; }
        public string SourceType { get; set; }
        public string SourceTitle { get; set; }
        public string SourceText { get; set; }
        public string SourceHtml { get; set; }
        public string SourceThumbnail { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsMedium
    {
        public uint MediaId { get; set; }
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

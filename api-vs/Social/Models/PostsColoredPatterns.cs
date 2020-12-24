using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsColoredPatterns
    {
        public int PatternId { get; set; }
        public string Type { get; set; }
        public string BackgroundImage { get; set; }
        public string BackgroundColor1 { get; set; }
        public string BackgroundColor2 { get; set; }
        public string TextColor { get; set; }
    }
}

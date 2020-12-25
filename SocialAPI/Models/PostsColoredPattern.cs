using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsColoredPattern
    {
        public uint PatternId { get; set; }
        public string Type { get; set; }
        public string BackgroundImage { get; set; }
        public string BackgroundColor1 { get; set; }
        public string BackgroundColor2 { get; set; }
        public string TextColor { get; set; }
    }
}

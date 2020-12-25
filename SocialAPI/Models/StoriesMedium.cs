using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class StoriesMedium
    {
        public uint MediaId { get; set; }
        public uint StoryId { get; set; }
        public string Source { get; set; }
        public string IsPhoto { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
    }
}

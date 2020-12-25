using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Story
    {
        public uint StoryId { get; set; }
        public uint UserId { get; set; }
        public DateTime Time { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Emoji
    {
        public uint EmojiId { get; set; }
        public string Pattern { get; set; }
        public string Class { get; set; }
    }
}

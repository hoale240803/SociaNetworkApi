using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsPollsOption
    {
        public uint OptionId { get; set; }
        public uint PollId { get; set; }
        public string Text { get; set; }
    }
}

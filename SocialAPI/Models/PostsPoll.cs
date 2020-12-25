using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsPoll
    {
        public uint PollId { get; set; }
        public uint PostId { get; set; }
        public uint Votes { get; set; }
    }
}

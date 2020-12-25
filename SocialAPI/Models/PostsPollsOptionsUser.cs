using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsPollsOptionsUser
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint PollId { get; set; }
        public uint OptionId { get; set; }
    }
}

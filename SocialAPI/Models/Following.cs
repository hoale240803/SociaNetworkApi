using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Following
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint FollowingId { get; set; }
    }
}

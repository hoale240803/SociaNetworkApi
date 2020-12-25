using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class UsersPoke
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint PokedId { get; set; }
    }
}

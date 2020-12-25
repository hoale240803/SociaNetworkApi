using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class UsersBlock
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint BlockedId { get; set; }
    }
}

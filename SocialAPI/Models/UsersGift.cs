using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class UsersGift
    {
        public uint Id { get; set; }
        public uint FromUserId { get; set; }
        public uint ToUserId { get; set; }
        public uint GiftId { get; set; }
    }
}

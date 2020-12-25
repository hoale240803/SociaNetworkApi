using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PagesInvite
    {
        public uint Id { get; set; }
        public uint PageId { get; set; }
        public uint UserId { get; set; }
        public uint FromUserId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class AnnouncementsUser
    {
        public uint Id { get; set; }
        public uint AnnouncementId { get; set; }
        public uint UserId { get; set; }
    }
}

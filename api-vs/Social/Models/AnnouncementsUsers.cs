using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class AnnouncementsUsers
    {
        public int Id { get; set; }
        public int AnnouncementId { get; set; }
        public int UserId { get; set; }
    }
}

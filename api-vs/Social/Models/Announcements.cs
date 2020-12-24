using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Announcements
    {
        public int AnnouncementId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
    }
}

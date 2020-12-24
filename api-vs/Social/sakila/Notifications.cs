using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Notifications
    {
        public int NotifyId { get; set; }
        public int NotifyBy { get; set; }
        public int NotifyTo { get; set; }
        public int PostId { get; set; }
        public int GroupId { get; set; }
        public string Type { get; set; }
        public int User { get; set; }
        public string NotifyTime { get; set; }
        public string Status { get; set; }
    }
}

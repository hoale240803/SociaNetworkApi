using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Notifications
    {
        public int NotificationId { get; set; }
        public int ToUserId { get; set; }
        public int FromUserId { get; set; }
        public string Action { get; set; }
        public string NodeType { get; set; }
        public string NodeUrl { get; set; }
        public string NotifyId { get; set; }
        public string Message { get; set; }
        public string Seen { get; set; }
    }
}

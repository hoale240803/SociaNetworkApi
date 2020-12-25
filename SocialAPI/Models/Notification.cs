using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Notification
    {
        public uint NotificationId { get; set; }
        public uint ToUserId { get; set; }
        public uint FromUserId { get; set; }
        public string Action { get; set; }
        public string NodeType { get; set; }
        public string NodeUrl { get; set; }
        public string NotifyId { get; set; }
        public string Message { get; set; }
        public DateTime? Time { get; set; }
        public string Seen { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class ConversationsCallsVideo
    {
        public uint CallId { get; set; }
        public uint FromUserId { get; set; }
        public string FromUserToken { get; set; }
        public uint ToUserId { get; set; }
        public string ToUserToken { get; set; }
        public string Room { get; set; }
        public string Answered { get; set; }
        public string Declined { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}

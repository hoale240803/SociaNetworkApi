using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class ConversationsCallsVideo
    {
        public int CallId { get; set; }
        public int FromUserId { get; set; }
        public string FromUserToken { get; set; }
        public int ToUserId { get; set; }
        public string ToUserToken { get; set; }
        public string Room { get; set; }
        public string Answered { get; set; }
        public string Declined { get; set; }
    }
}

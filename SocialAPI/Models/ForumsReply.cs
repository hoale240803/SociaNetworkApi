using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class ForumsReply
    {
        public uint ReplyId { get; set; }
        public uint ThreadId { get; set; }
        public uint UserId { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
    }
}

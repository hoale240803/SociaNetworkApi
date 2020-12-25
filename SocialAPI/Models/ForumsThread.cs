using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class ForumsThread
    {
        public uint ThreadId { get; set; }
        public uint ForumId { get; set; }
        public uint UserId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public uint Replies { get; set; }
        public uint Views { get; set; }
        public DateTime Time { get; set; }
        public DateTime? LastReply { get; set; }
    }
}

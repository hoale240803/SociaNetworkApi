using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Forum
    {
        public uint ForumId { get; set; }
        public uint ForumSection { get; set; }
        public string ForumName { get; set; }
        public string ForumDescription { get; set; }
        public uint ForumOrder { get; set; }
        public uint ForumThreads { get; set; }
        public uint ForumReplies { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Forums
    {
        public int ForumId { get; set; }
        public int ForumSection { get; set; }
        public string ForumName { get; set; }
        public string ForumDescription { get; set; }
        public int ForumOrder { get; set; }
        public int ForumThreads { get; set; }
        public int ForumReplies { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class ForumsReplies
    {
        public int ReplyId { get; set; }
        public int ThreadId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
    }
}

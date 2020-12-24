using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class ForumsThreads
    {
        public int ThreadId { get; set; }
        public int ForumId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Replies { get; set; }
        public int Views { get; set; }
    }
}

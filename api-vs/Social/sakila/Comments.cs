using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Comments
    {
        public int CommentId { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
        public string CommentSrc { get; set; }
        public int CommentBy { get; set; }
        public int PostId { get; set; }
        public string CommentTime { get; set; }
    }
}

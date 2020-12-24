using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsFiles
    {
        public int FileId { get; set; }
        public int PostId { get; set; }
        public string Source { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class PostTags
    {
        public int PostTagId { get; set; }
        public int PostId { get; set; }
        public int User { get; set; }
    }
}

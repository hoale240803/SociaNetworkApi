using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Hashtags
    {
        public int HashtagId { get; set; }
        public string Hashtag { get; set; }
        public int PostId { get; set; }
        public int User { get; set; }
        public string HashtagTime { get; set; }
    }
}

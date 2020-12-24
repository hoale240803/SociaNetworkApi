using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Likes
    {
        public int LikeId { get; set; }
        public int PostId { get; set; }
        public int LikeBy { get; set; }
        public string LikeTime { get; set; }
    }
}

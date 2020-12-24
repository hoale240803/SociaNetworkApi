using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class FollowSystem
    {
        public int FollowId { get; set; }
        public int FollowBy { get; set; }
        public string FollowByUsername { get; set; }
        public int FollowTo { get; set; }
        public string FollowToUsername { get; set; }
        public string FollowTime { get; set; }
    }
}

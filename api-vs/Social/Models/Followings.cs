using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Followings
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FollowingId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsLiveUsers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsReactions
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Reaction { get; set; }
        public string PointsEarned { get; set; }
    }
}

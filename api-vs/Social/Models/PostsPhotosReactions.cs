using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsPhotosReactions
    {
        public int Id { get; set; }
        public int PhotoId { get; set; }
        public int UserId { get; set; }
        public string Reaction { get; set; }
        public string PointsEarned { get; set; }
    }
}

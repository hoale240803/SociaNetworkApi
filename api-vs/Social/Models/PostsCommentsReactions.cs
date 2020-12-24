using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsCommentsReactions
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public string Reaction { get; set; }
        public string PointsEarned { get; set; }
    }
}

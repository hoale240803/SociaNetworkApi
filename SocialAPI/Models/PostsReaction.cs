using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsReaction
    {
        public uint Id { get; set; }
        public uint PostId { get; set; }
        public uint UserId { get; set; }
        public string Reaction { get; set; }
        public DateTime? ReactionTime { get; set; }
        public string PointsEarned { get; set; }
    }
}

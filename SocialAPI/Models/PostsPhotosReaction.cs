using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsPhotosReaction
    {
        public uint Id { get; set; }
        public uint PhotoId { get; set; }
        public uint UserId { get; set; }
        public string Reaction { get; set; }
        public DateTime? ReactionTime { get; set; }
        public string PointsEarned { get; set; }
    }
}

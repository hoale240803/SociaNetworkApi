using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsComment
    {
        public uint CommentId { get; set; }
        public uint NodeId { get; set; }
        public string NodeType { get; set; }
        public uint UserId { get; set; }
        public string UserType { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string VoiceNote { get; set; }
        public DateTime Time { get; set; }
        public uint ReactionLikeCount { get; set; }
        public uint ReactionLoveCount { get; set; }
        public uint ReactionHahaCount { get; set; }
        public uint ReactionYayCount { get; set; }
        public uint ReactionWowCount { get; set; }
        public uint ReactionSadCount { get; set; }
        public uint ReactionAngryCount { get; set; }
        public uint Replies { get; set; }
        public string PointsEarned { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsComments
    {
        public int CommentId { get; set; }
        public int NodeId { get; set; }
        public string NodeType { get; set; }
        public int UserId { get; set; }
        public string UserType { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string VoiceNote { get; set; }
        public int ReactionLikeCount { get; set; }
        public int ReactionLoveCount { get; set; }
        public int ReactionHahaCount { get; set; }
        public int ReactionYayCount { get; set; }
        public int ReactionWowCount { get; set; }
        public int ReactionSadCount { get; set; }
        public int ReactionAngryCount { get; set; }
        public int Replies { get; set; }
        public string PointsEarned { get; set; }
    }
}

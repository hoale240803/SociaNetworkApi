using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Post
    {
        public uint PostId { get; set; }
        public uint UserId { get; set; }
        public string UserType { get; set; }
        public string InGroup { get; set; }
        public uint? GroupId { get; set; }
        public string GroupApproved { get; set; }
        public string InEvent { get; set; }
        public uint? EventId { get; set; }
        public string EventApproved { get; set; }
        public string InWall { get; set; }
        public uint? WallId { get; set; }
        public string PostType { get; set; }
        public uint? ColoredPattern { get; set; }
        public uint? OriginId { get; set; }
        public DateTime Time { get; set; }
        public string Location { get; set; }
        public string Privacy { get; set; }
        public string Text { get; set; }
        public string FeelingAction { get; set; }
        public string FeelingValue { get; set; }
        public string Boosted { get; set; }
        public uint? BoostedBy { get; set; }
        public string CommentsDisabled { get; set; }
        public string IsHidden { get; set; }
        public string IsAnonymous { get; set; }
        public uint ReactionLikeCount { get; set; }
        public uint ReactionLoveCount { get; set; }
        public uint ReactionHahaCount { get; set; }
        public uint ReactionYayCount { get; set; }
        public uint ReactionWowCount { get; set; }
        public uint ReactionSadCount { get; set; }
        public uint ReactionAngryCount { get; set; }
        public uint Comments { get; set; }
        public uint Shares { get; set; }
        public string PointsEarned { get; set; }
    }
}

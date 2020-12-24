using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.DTO
{
    public class PostDTO
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string UserType { get; set; }
        public string InGroup { get; set; }
        public int? GroupId { get; set; }
        public string GroupApproved { get; set; }
        public string InEvent { get; set; }
        public int? EventId { get; set; }
        public string EventApproved { get; set; }
        public string InWall { get; set; }
        public int? WallId { get; set; }
        public string PostType { get; set; }
        public int? ColoredPattern { get; set; }
        public int? OriginId { get; set; }
        public string Location { get; set; }
        public string Privacy { get; set; }
        public string Text { get; set; }
        public string FeelingAction { get; set; }
        public string FeelingValue { get; set; }
        public string Boosted { get; set; }
        public int? BoostedBy { get; set; }
        public string CommentsDisabled { get; set; }
        public string IsHidden { get; set; }
        public string IsAnonymous { get; set; }
        public int ReactionLikeCount { get; set; }
        public int ReactionLoveCount { get; set; }
        public int ReactionHahaCount { get; set; }
        public int ReactionYayCount { get; set; }
        public int ReactionWowCount { get; set; }
        public int ReactionSadCount { get; set; }
        public int ReactionAngryCount { get; set; }
        public int Comments { get; set; }
        public int Shares { get; set; }
        public string PointsEarned { get; set; }
    }
}

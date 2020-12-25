using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsPhoto
    {
        public uint PhotoId { get; set; }
        public uint PostId { get; set; }
        public uint? AlbumId { get; set; }
        public string Source { get; set; }
        public string Blur { get; set; }
        public uint ReactionLikeCount { get; set; }
        public uint ReactionLoveCount { get; set; }
        public uint ReactionHahaCount { get; set; }
        public uint ReactionYayCount { get; set; }
        public uint ReactionWowCount { get; set; }
        public uint ReactionSadCount { get; set; }
        public uint ReactionAngryCount { get; set; }
        public uint Comments { get; set; }
    }
}

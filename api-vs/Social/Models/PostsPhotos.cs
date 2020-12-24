using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsPhotos
    {
        public int PhotoId { get; set; }
        public int PostId { get; set; }
        public int? AlbumId { get; set; }
        public string Source { get; set; }
        public string Blur { get; set; }
        public int ReactionLikeCount { get; set; }
        public int ReactionLoveCount { get; set; }
        public int ReactionHahaCount { get; set; }
        public int ReactionYayCount { get; set; }
        public int ReactionWowCount { get; set; }
        public int ReactionSadCount { get; set; }
        public int ReactionAngryCount { get; set; }
        public int Comments { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsArticle
    {
        public uint ArticleId { get; set; }
        public uint PostId { get; set; }
        public string Cover { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public uint CategoryId { get; set; }
        public string Tags { get; set; }
        public uint Views { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsArticles
    {
        public int ArticleId { get; set; }
        public int PostId { get; set; }
        public string Cover { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int CategoryId { get; set; }
        public string Tags { get; set; }
        public int Views { get; set; }
    }
}

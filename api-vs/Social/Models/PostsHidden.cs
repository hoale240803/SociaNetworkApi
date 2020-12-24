using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsHidden
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
    }
}

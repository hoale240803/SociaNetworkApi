using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsSaved
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
    }
}

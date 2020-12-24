using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class HashtagsPosts
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int HashtagId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsPolls
    {
        public int PollId { get; set; }
        public int PostId { get; set; }
        public int Votes { get; set; }
    }
}

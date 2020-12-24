using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsPollsOptions
    {
        public int OptionId { get; set; }
        public int PollId { get; set; }
        public string Text { get; set; }
    }
}

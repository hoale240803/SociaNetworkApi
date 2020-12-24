using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsPollsOptionsUsers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PollId { get; set; }
        public int OptionId { get; set; }
    }
}

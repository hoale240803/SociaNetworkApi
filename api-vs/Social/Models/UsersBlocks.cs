using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class UsersBlocks
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BlockedId { get; set; }
    }
}

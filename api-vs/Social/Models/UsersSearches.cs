using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class UsersSearches
    {
        public int LogId { get; set; }
        public int UserId { get; set; }
        public int NodeId { get; set; }
        public string NodeType { get; set; }
    }
}

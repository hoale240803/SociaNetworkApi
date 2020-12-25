using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class UsersSearch
    {
        public uint LogId { get; set; }
        public uint UserId { get; set; }
        public uint NodeId { get; set; }
        public string NodeType { get; set; }
        public DateTime? Time { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Blacklist
    {
        public uint NodeId { get; set; }
        public string NodeType { get; set; }
        public string NodeValue { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}

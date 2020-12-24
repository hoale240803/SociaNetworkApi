using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Blacklist
    {
        public int NodeId { get; set; }
        public string NodeType { get; set; }
        public string NodeValue { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Report
    {
        public uint ReportId { get; set; }
        public uint UserId { get; set; }
        public uint NodeId { get; set; }
        public string NodeType { get; set; }
        public DateTime Time { get; set; }
    }
}

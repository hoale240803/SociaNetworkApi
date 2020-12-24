using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Reports
    {
        public int ReportId { get; set; }
        public int UserId { get; set; }
        public int NodeId { get; set; }
        public string NodeType { get; set; }
    }
}

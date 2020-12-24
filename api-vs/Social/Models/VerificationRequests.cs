using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class VerificationRequests
    {
        public int RequestId { get; set; }
        public int NodeId { get; set; }
        public string NodeType { get; set; }
        public string Photo { get; set; }
        public string Passport { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
    }
}

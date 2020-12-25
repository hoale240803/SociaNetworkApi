using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class VerificationRequest
    {
        public uint RequestId { get; set; }
        public uint NodeId { get; set; }
        public string NodeType { get; set; }
        public string Photo { get; set; }
        public string Passport { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool Status { get; set; }
    }
}

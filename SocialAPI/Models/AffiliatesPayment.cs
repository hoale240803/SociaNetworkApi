using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class AffiliatesPayment
    {
        public int PaymentId { get; set; }
        public uint UserId { get; set; }
        public string Amount { get; set; }
        public string Method { get; set; }
        public string MethodValue { get; set; }
        public DateTime Time { get; set; }
        public bool Status { get; set; }
    }
}

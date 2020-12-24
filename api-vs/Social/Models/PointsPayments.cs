using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PointsPayments
    {
        public int PaymentId { get; set; }
        public int UserId { get; set; }
        public string Amount { get; set; }
        public string Method { get; set; }
        public string MethodValue { get; set; }
        public bool Status { get; set; }
    }
}

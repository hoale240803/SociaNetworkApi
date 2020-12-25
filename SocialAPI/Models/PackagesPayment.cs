using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PackagesPayment
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PackageName { get; set; }
        public string PackagePrice { get; set; }
    }
}

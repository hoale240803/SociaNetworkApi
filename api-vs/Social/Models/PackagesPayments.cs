using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PackagesPayments
    {
        public int PaymentId { get; set; }
        public string PackageName { get; set; }
        public string PackagePrice { get; set; }
    }
}

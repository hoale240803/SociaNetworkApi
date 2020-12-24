using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class BankTransfers
    {
        public int TransferId { get; set; }
        public int UserId { get; set; }
        public string Handle { get; set; }
        public int? PackageId { get; set; }
        public string Price { get; set; }
        public string BankReceipt { get; set; }
        public bool Status { get; set; }
    }
}

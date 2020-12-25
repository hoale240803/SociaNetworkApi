using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class BankTransfer
    {
        public uint TransferId { get; set; }
        public uint UserId { get; set; }
        public string Handle { get; set; }
        public uint? PackageId { get; set; }
        public string Price { get; set; }
        public string BankReceipt { get; set; }
        public DateTime Time { get; set; }
        public bool Status { get; set; }
    }
}

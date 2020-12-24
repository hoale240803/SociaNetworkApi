using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class AdsUsersWalletTransactions
    {
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public string NodeType { get; set; }
        public int? NodeId { get; set; }
        public string Amount { get; set; }
        public string Type { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class CoinpaymentsTransaction
    {
        public uint TransactionId { get; set; }
        public string TransactionTxnId { get; set; }
        public uint UserId { get; set; }
        public string Amount { get; set; }
        public string Product { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdate { get; set; }
        public byte Status { get; set; }
        public string StatusMessage { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class CoinpaymentsTransactions
    {
        public int TransactionId { get; set; }
        public string TransactionTxnId { get; set; }
        public int UserId { get; set; }
        public string Amount { get; set; }
        public string Product { get; set; }
        public byte Status { get; set; }
        public string StatusMessage { get; set; }
    }
}

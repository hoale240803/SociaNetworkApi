using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class AdsUsersWalletTransaction
    {
        public int TransactionId { get; set; }
        public uint UserId { get; set; }
        public string NodeType { get; set; }
        public uint? NodeId { get; set; }
        public string Amount { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
    }
}

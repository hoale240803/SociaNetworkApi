using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsOffer
    {
        public uint OfferId { get; set; }
        public uint PostId { get; set; }
        public uint CategoryId { get; set; }
        public string Title { get; set; }
        public string DiscountType { get; set; }
        public uint DiscountPercent { get; set; }
        public string DiscountAmount { get; set; }
        public string BuyX { get; set; }
        public string GetY { get; set; }
        public string SpendX { get; set; }
        public string AmountY { get; set; }
        public DateTime EndDate { get; set; }
        public string Thumbnail { get; set; }
    }
}

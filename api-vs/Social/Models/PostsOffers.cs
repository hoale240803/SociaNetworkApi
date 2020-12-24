using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsOffers
    {
        public int OfferId { get; set; }
        public int PostId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string DiscountType { get; set; }
        public int DiscountPercent { get; set; }
        public string DiscountAmount { get; set; }
        public string BuyX { get; set; }
        public string GetY { get; set; }
        public string SpendX { get; set; }
        public string AmountY { get; set; }
        public string Thumbnail { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class MarketCategories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int CategoryOrder { get; set; }
    }
}

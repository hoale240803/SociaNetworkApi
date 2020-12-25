using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class SystemCurrency
    {
        public uint CurrencyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Default { get; set; }
    }
}

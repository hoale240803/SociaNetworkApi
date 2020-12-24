using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class SystemCurrencies
    {
        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Default { get; set; }
    }
}

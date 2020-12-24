using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class StaticPages
    {
        public int PageId { get; set; }
        public string PageUrl { get; set; }
        public string PageTitle { get; set; }
        public string PageText { get; set; }
        public string PageInFooter { get; set; }
        public int PageOrder { get; set; }
    }
}

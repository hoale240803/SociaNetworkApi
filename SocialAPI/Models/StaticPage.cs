using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class StaticPage
    {
        public int PageId { get; set; }
        public string PageUrl { get; set; }
        public string PageTitle { get; set; }
        public string PageText { get; set; }
        public string PageInFooter { get; set; }
        public int PageOrder { get; set; }
    }
}

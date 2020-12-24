using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Packages
    {
        public int PackageId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int PeriodNum { get; set; }
        public string Period { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
        public string VerificationBadgeEnabled { get; set; }
        public string BoostPostsEnabled { get; set; }
        public int BoostPosts { get; set; }
        public string BoostPagesEnabled { get; set; }
        public int BoostPages { get; set; }
    }
}

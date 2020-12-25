using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Package
    {
        public int PackageId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public uint PeriodNum { get; set; }
        public string Period { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
        public string VerificationBadgeEnabled { get; set; }
        public string BoostPostsEnabled { get; set; }
        public uint BoostPosts { get; set; }
        public string BoostPagesEnabled { get; set; }
        public uint BoostPages { get; set; }
    }
}

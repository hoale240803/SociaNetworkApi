using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class AdsSystem
    {
        public int AdsId { get; set; }
        public string Title { get; set; }
        public string Place { get; set; }
        public string Code { get; set; }
        public DateTime Time { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Recommendations
    {
        public int RecommendId { get; set; }
        public int RecommendBy { get; set; }
        public int RecommendTo { get; set; }
        public int RecommendOf { get; set; }
        public string RecommendTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Shares
    {
        public int ShareId { get; set; }
        public int ShareBy { get; set; }
        public int ShareTo { get; set; }
        public int PostId { get; set; }
        public string ShareTime { get; set; }
    }
}

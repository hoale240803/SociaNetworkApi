using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Blocks
    {
        public int BlockId { get; set; }
        public int BlockBy { get; set; }
        public int User { get; set; }
        public string BlockTime { get; set; }
    }
}

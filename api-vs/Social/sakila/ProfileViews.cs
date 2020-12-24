using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class ProfileViews
    {
        public int ViewId { get; set; }
        public int ViewBy { get; set; }
        public int ViewTo { get; set; }
        public string ViewTime { get; set; }
    }
}

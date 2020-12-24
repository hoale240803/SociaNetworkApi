using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Groups
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public int Admin { get; set; }
        public string GroupType { get; set; }
        public string Created { get; set; }
    }
}

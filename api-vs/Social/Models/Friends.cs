using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Friends
    {
        public int Id { get; set; }
        public int UserOneId { get; set; }
        public int UserTwoId { get; set; }
        public bool Status { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class UsersPokes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PokedId { get; set; }
    }
}

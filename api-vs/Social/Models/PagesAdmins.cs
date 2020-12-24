using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PagesAdmins
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public int UserId { get; set; }
    }
}

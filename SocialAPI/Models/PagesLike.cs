using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PagesLike
    {
        public uint Id { get; set; }
        public uint PageId { get; set; }
        public uint UserId { get; set; }
    }
}

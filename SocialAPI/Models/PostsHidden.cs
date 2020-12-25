using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsHidden
    {
        public uint Id { get; set; }
        public uint PostId { get; set; }
        public uint UserId { get; set; }
    }
}

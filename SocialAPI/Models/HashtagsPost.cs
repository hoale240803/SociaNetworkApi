using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class HashtagsPost
    {
        public uint Id { get; set; }
        public uint PostId { get; set; }
        public uint HashtagId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsProduct
    {
        public uint ProductId { get; set; }
        public uint PostId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public uint CategoryId { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string Available { get; set; }
    }
}

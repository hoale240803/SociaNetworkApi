using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsProducts
    {
        public int ProductId { get; set; }
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int CategoryId { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string Available { get; set; }
    }
}

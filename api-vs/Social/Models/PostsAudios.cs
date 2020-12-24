using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsAudios
    {
        public int AudioId { get; set; }
        public int PostId { get; set; }
        public string Source { get; set; }
        public int Views { get; set; }
    }
}

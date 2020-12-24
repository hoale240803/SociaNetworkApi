using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsPhotosAlbums
    {
        public int AlbumId { get; set; }
        public int UserId { get; set; }
        public string UserType { get; set; }
        public string InGroup { get; set; }
        public int? GroupId { get; set; }
        public string InEvent { get; set; }
        public int? EventId { get; set; }
        public string Title { get; set; }
        public string Privacy { get; set; }
    }
}

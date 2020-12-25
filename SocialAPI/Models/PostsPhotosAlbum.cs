using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsPhotosAlbum
    {
        public uint AlbumId { get; set; }
        public uint UserId { get; set; }
        public string UserType { get; set; }
        public string InGroup { get; set; }
        public uint? GroupId { get; set; }
        public string InEvent { get; set; }
        public uint? EventId { get; set; }
        public string Title { get; set; }
        public string Privacy { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class MoviesGenre
    {
        public uint GenreId { get; set; }
        public string GenreName { get; set; }
        public uint GenreOrder { get; set; }
        public string GenreDescription { get; set; }
    }
}

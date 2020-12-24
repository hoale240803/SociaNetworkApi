using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class MoviesGenres
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public int GenreOrder { get; set; }
        public string GenreDescription { get; set; }
    }
}

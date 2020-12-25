using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Movie
    {
        public uint MovieId { get; set; }
        public string Source { get; set; }
        public string SourceType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImdbUrl { get; set; }
        public string Stars { get; set; }
        public int? ReleaseYear { get; set; }
        public int? Duration { get; set; }
        public string Genres { get; set; }
        public string Poster { get; set; }
        public uint Views { get; set; }
    }
}

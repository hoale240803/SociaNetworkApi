using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Games
    {
        public int GameId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public string Thumbnail { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class GamesPlayers
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
    }
}

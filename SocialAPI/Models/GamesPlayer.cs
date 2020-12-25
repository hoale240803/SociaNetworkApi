using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class GamesPlayer
    {
        public uint Id { get; set; }
        public uint GameId { get; set; }
        public uint UserId { get; set; }
        public DateTime? LastPlayedTime { get; set; }
    }
}

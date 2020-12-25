using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class EventsMember
    {
        public uint Id { get; set; }
        public uint EventId { get; set; }
        public uint UserId { get; set; }
        public string IsInvited { get; set; }
        public string IsInterested { get; set; }
        public string IsGoing { get; set; }
    }
}

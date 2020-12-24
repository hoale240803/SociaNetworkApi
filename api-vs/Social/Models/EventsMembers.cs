using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class EventsMembers
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public string IsInvited { get; set; }
        public string IsInterested { get; set; }
        public string IsGoing { get; set; }
    }
}

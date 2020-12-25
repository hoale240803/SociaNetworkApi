using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class ConversationsUser
    {
        public uint Id { get; set; }
        public uint ConversationId { get; set; }
        public uint UserId { get; set; }
        public string Seen { get; set; }
        public string Typing { get; set; }
        public string Deleted { get; set; }
    }
}

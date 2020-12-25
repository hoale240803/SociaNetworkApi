using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Conversation
    {
        public uint ConversationId { get; set; }
        public uint LastMessageId { get; set; }
        public string Color { get; set; }
    }
}

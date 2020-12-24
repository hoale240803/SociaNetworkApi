using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Conversations
    {
        public int ConversationId { get; set; }
        public int LastMessageId { get; set; }
        public string Color { get; set; }
    }
}

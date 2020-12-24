using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class ConversationsMessages
    {
        public int MessageId { get; set; }
        public int ConversationId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public string Image { get; set; }
        public string VoiceNote { get; set; }
    }
}

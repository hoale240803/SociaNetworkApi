using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class ConversationsMessage
    {
        public uint MessageId { get; set; }
        public uint ConversationId { get; set; }
        public uint UserId { get; set; }
        public string Message { get; set; }
        public string Image { get; set; }
        public string VoiceNote { get; set; }
        public DateTime Time { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class ConversationsUsers
    {
        public int Id { get; set; }
        public int ConversationId { get; set; }
        public int UserId { get; set; }
        public string Seen { get; set; }
        public string Typing { get; set; }
        public string Deleted { get; set; }
    }
}

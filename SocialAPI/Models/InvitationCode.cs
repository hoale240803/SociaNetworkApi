using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class InvitationCode
    {
        public uint CodeId { get; set; }
        public string Code { get; set; }
        public string Valid { get; set; }
        public DateTime Date { get; set; }
    }
}

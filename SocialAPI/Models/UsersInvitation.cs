using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class UsersInvitation
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string Email { get; set; }
        public DateTime InvitationDate { get; set; }
    }
}

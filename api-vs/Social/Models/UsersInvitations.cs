using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class UsersInvitations
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class GroupsAdmin
    {
        public uint Id { get; set; }
        public uint GroupId { get; set; }
        public uint UserId { get; set; }
    }
}

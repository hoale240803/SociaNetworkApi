using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Friend
    {
        public uint Id { get; set; }
        public uint UserOneId { get; set; }
        public uint UserTwoId { get; set; }
        public bool Status { get; set; }
    }
}

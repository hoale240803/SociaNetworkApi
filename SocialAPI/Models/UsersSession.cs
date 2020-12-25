using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class UsersSession
    {
        public uint SessionId { get; set; }
        public string SessionToken { get; set; }
        public DateTime SessionDate { get; set; }
        public uint UserId { get; set; }
        public string UserBrowser { get; set; }
        public string UserOs { get; set; }
        public string UserIp { get; set; }
    }
}

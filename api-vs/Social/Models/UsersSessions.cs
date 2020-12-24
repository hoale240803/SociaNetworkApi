using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class UsersSessions
    {
        public int SessionId { get; set; }
        public string SessionToken { get; set; }
        public int UserId { get; set; }
        public string UserBrowser { get; set; }
        public string UserOs { get; set; }
        public string UserIp { get; set; }
    }
}

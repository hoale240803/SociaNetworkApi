using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class DevelopersAppsUser
    {
        public uint Id { get; set; }
        public uint AppId { get; set; }
        public uint UserId { get; set; }
        public string AuthKey { get; set; }
        public string AccessToken { get; set; }
        public DateTime? AccessTokenDate { get; set; }
    }
}

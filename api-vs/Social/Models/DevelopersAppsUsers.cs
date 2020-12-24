using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class DevelopersAppsUsers
    {
        public int Id { get; set; }
        public int AppId { get; set; }
        public int UserId { get; set; }
        public string AuthKey { get; set; }
        public string AccessToken { get; set; }
    }
}

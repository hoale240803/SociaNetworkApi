using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class DevelopersApps
    {
        public int AppId { get; set; }
        public int AppUserId { get; set; }
        public int AppCategoryId { get; set; }
        public string AppAuthId { get; set; }
        public string AppAuthSecret { get; set; }
        public string AppName { get; set; }
        public string AppDomain { get; set; }
        public string AppRedirectUrl { get; set; }
        public string AppDescription { get; set; }
        public string AppIcon { get; set; }
    }
}

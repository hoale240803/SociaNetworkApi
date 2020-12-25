using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class DevelopersApp
    {
        public uint AppId { get; set; }
        public uint AppUserId { get; set; }
        public uint AppCategoryId { get; set; }
        public string AppAuthId { get; set; }
        public string AppAuthSecret { get; set; }
        public string AppName { get; set; }
        public string AppDomain { get; set; }
        public string AppRedirectUrl { get; set; }
        public string AppDescription { get; set; }
        public string AppIcon { get; set; }
        public DateTime AppDate { get; set; }
    }
}

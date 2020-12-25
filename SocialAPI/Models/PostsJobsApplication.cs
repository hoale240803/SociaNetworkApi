using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsJobsApplication
    {
        public uint ApplicationId { get; set; }
        public uint PostId { get; set; }
        public uint UserId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WorkPlace { get; set; }
        public string WorkPosition { get; set; }
        public string WorkDescription { get; set; }
        public string WorkFrom { get; set; }
        public string WorkTo { get; set; }
        public string WorkNow { get; set; }
        public string Question1Answer { get; set; }
        public string Question2Answer { get; set; }
        public string Question3Answer { get; set; }
        public DateTime AppliedTime { get; set; }
    }
}

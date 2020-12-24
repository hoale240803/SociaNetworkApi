using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsJobsApplications
    {
        public int ApplicationId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
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
    }
}

using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsJobs
    {
        public int JobId { get; set; }
        public int PostId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string SalaryMinimum { get; set; }
        public string SalaryMaximum { get; set; }
        public string PaySalaryPer { get; set; }
        public string Type { get; set; }
        public string Question1Type { get; set; }
        public string Question1Title { get; set; }
        public string Question1Choices { get; set; }
        public string Question2Type { get; set; }
        public string Question2Title { get; set; }
        public string Question2Choices { get; set; }
        public string Question3Type { get; set; }
        public string Question3Title { get; set; }
        public string Question3Choices { get; set; }
        public string CoverImage { get; set; }
        public string Available { get; set; }
    }
}

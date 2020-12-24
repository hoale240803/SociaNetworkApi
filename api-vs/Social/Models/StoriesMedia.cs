using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class StoriesMedia
    {
        public int MediaId { get; set; }
        public int StoryId { get; set; }
        public string Source { get; set; }
        public string IsPhoto { get; set; }
        public string Text { get; set; }
    }
}

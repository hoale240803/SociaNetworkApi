using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class SystemLanguages
    {
        public int LanguageId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Flag { get; set; }
        public string Dir { get; set; }
        public string Default { get; set; }
        public string Enabled { get; set; }
    }
}

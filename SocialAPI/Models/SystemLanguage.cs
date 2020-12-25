using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class SystemLanguage
    {
        public uint LanguageId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Flag { get; set; }
        public string Dir { get; set; }
        public string Default { get; set; }
        public string Enabled { get; set; }
    }
}

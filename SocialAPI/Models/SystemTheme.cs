using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class SystemTheme
    {
        public uint ThemeId { get; set; }
        public string Name { get; set; }
        public string Default { get; set; }
    }
}

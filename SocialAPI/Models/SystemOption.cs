using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class SystemOption
    {
        public uint OptionId { get; set; }
        public string OptionName { get; set; }
        public string OptionValue { get; set; }
    }
}

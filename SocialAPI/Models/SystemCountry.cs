using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class SystemCountry
    {
        public uint CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }
}

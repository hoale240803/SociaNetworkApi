﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class OffersCategory
    {
        public uint CategoryId { get; set; }
        public string CategoryName { get; set; }
        public uint CategoryOrder { get; set; }
    }
}
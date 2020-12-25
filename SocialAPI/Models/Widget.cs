using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Widget
    {
        public uint WidgetId { get; set; }
        public string Title { get; set; }
        public string Place { get; set; }
        public uint PlaceOrder { get; set; }
        public string Code { get; set; }
    }
}

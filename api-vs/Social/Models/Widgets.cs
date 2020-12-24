using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Widgets
    {
        public int WidgetId { get; set; }
        public string Title { get; set; }
        public string Place { get; set; }
        public int PlaceOrder { get; set; }
        public string Code { get; set; }
    }
}

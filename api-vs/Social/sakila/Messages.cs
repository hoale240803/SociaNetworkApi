using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Messages
    {
        public int MessageId { get; set; }
        public int ConId { get; set; }
        public int MssgBy { get; set; }
        public int MssgTo { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string MessageTime { get; set; }
    }
}

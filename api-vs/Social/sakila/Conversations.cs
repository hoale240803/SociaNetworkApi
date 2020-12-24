using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Conversations
    {
        public int ConId { get; set; }
        public int UserOne { get; set; }
        public int UserTwo { get; set; }
        public string ConTime { get; set; }
    }
}

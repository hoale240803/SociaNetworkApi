using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class InvitationCodes
    {
        public int CodeId { get; set; }
        public string Code { get; set; }
        public string Valid { get; set; }
    }
}

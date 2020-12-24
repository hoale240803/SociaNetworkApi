using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class GroupMembers
    {
        public int GrpMemberId { get; set; }
        public int GroupId { get; set; }
        public int Member { get; set; }
        public int AddedBy { get; set; }
        public string JoinedGroup { get; set; }
    }
}

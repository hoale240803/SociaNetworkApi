using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class GroupsMembers
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public string Approved { get; set; }
    }
}

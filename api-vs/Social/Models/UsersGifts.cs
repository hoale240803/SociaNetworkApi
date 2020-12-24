using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class UsersGifts
    {
        public int Id { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public int GiftId { get; set; }
    }
}

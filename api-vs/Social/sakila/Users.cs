using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Bio { get; set; }
        public string Joined { get; set; }
        public string EmailVerified { get; set; }
        public string AccountType { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Github { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string IsOnline { get; set; }
        public string LastOnline { get; set; }
    }
}

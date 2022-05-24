using System;
using TheLight_ECommerce.Enums;
using System.Collections.Generic;
using System.Text;

namespace TheLight_ECommerce.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNo { get; set; }
        public decimal Wallet { get; set; }
        public Role Role { get; set; }

        public  User(int id, string firstName, string lastName, string email, string password, 
            string phoneNo, decimal wallet,  Role role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNo = phoneNo;
            Wallet = wallet;
            Role = role;
        }
    }
}

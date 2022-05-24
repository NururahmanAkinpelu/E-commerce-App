using System;
using TheLight_ECommerce.Enums;
using System.Collections.Generic;
using System.Text;

namespace TheLight_ECommerce.Model
{
    public class Customer : User
    {
        
        public Customer(int id, string firstName, string lastName, string email, string password, string phoneNo, decimal wallet,
             Role role) :base(id, firstName, lastName, email, password, phoneNo,wallet, role)
        {

        }
    }
}

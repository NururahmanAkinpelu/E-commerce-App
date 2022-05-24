using System;
using TheLight_ECommerce.Model;
using System.Collections.Generic;
using System.Text;

namespace TheLight_ECommerce.Manager.Interface
{
    public interface ICustomerManager
    {
        public void RegisterCustomer();
        public User GetCustomerByEmail(string email);
        
        /*public List<Customer> GetAllCustomers();*/
    }
}

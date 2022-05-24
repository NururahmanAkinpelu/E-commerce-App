using System;
using TheLight_ECommerce.Manager.Interface;
using TheLight_ECommerce.Enums;
using TheLight_ECommerce.Model;
using System.Collections.Generic;
using System.Text;
using TheLight_ECommerce.Menus;

namespace TheLight_ECommerce.Manager
{
    public class CustomerManager:ICustomerManager
    {       
        public static int CustomerId = 0;
        
        
        public  void RegisterCustomer()
        {
            CustomerId++;
            int Id = CustomerId;
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            string phone = Console.ReadLine();
                                    
            var role = Role.Customer;

            decimal wallet = 500000;

            var customer = new User(CustomerId, firstName, lastName, email, password, phone, wallet, role);
            UserManager.users.Add(customer);

            Console.WriteLine($"You have successfully regisered with us, you Id is {Id} ");
            /*customerMenu.Menu();*/
        }

        public User GetCustomerByEmail(string email)
        {
            foreach (var item in UserManager.users)
            {
                if(item.Email == email && item.Role == Role.Customer)
                {
                    return item;
                }
            }
            return null;
        }
        public User GetCustomerById(int id)
        {
            foreach (var item in UserManager.users)
            {
                if(item.Id == id && item.Role == Role.Customer)
                {
                    return item;
                }
            }
            return null;
        }
        


        
    }        
}

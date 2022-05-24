using System;

using System.Collections.Generic;
using System.Text;
using TheLight_ECommerce.Enums;
using TheLight_ECommerce.Menus;
using TheLight_ECommerce.Model;

namespace TheLight_ECommerce.Manager
{
    public class UserManager
    {
        public static List<User> users = new List<User>()
        {
            new Staff(1,"ST001", "Akinpelu", "Nuru-rahman", "olalekanakinpelu1@gmail.com", "1703", "09079665346",500000, Role.Manager),
            new Staff(2,"ST002", "ola", "dele", "oladele@gmail.com", "pass", "09067543276",50000, Role.Staffs),
            new Customer(3, "ade", "wale", "adewale@gmail.com", "pass", "08123456787", 5000, Role.Customer)                        
        };
        
        public User Login(string email, string password)
        {
            foreach (var user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user;
                }              
            }
            return null;
        }

        public void ViewWallet(User user)
        {
            Console.WriteLine($"Your wallet balance is {user.Wallet}");
        }

        public void AddMoneyToWallet(User user)
        {
            Console.WriteLine("How much do you want to add? : ");
            int addmoney = int.Parse(Console.ReadLine());
            user.Wallet += addmoney;
            Console.WriteLine($"Your balance is now {user.Wallet} ");
        }
    }
}

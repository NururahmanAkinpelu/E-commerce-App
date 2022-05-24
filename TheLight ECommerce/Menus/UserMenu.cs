using System;
using System.Collections.Generic;
using System.Text;
using TheLight_ECommerce.Enums;
using TheLight_ECommerce.Manager;

namespace TheLight_ECommerce.Menus
{
    public  class UserMenu
    {
        StaffMenu staffMenu = new StaffMenu();
        CustomerMenu customerMenu = new CustomerMenu();
        UserManager userManager = new UserManager();
        ManagerMenu managerMenu = new ManagerMenu();

        public void UserLogin()
        {
            Console.Write("Enter your email: ");
            var email = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = Console.ReadLine();

            var user = userManager.Login(email, password);
            if (user != null)
            {
                if (user.Role == Role.Manager)
                {
                    managerMenu.Menu(user);
                }

                else if (user.Role == Role.Staffs)
                {
                    staffMenu.Menu(user);
                }

                else if (user.Role == Role.Customer)
                {
                    customerMenu.Menu(user);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TheLight_ECommerce.Manager;
using TheLight_ECommerce.Model;
using TheLight_ECommerce.Manager.Interface;

namespace TheLight_ECommerce.Menus
{
    class ManagerMenu
    {
        ProductManager productManager = new ProductManager();
        StaffManager staffManager = new StaffManager();
        UserManager userManager = new UserManager();

        public void Menu(User user)
        {
            var exit = false;

            while (!exit)
            {
                /*Console.Clear();*/
                PrintManagerMenu();
                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            productManager.GetAllProducts();
                            break;
                        case 2:
                            productManager.AddProduct();
                            break;                     
                        case 3:
                            staffManager.RegisterStaff();
                            break;
                        case 4:
                            userManager.ViewWallet(user);
                            break;
                        case 5:
                            userManager.AddMoneyToWallet(user);
                            break;                            
                        case 0:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again....");
                            break;
                    }
                }
            }
        }

        public void PrintManagerMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1.\tView all products");
            Console.WriteLine("2.\tAdd Product");
            Console.WriteLine("3.\tRegister staff");
            Console.WriteLine("4.\tView wallet");
            Console.WriteLine("5.\tAdd money to wallet");
            Console.WriteLine("0.\tExit");            
        }

    }
}

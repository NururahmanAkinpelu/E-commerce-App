using System;
using TheLight_ECommerce.Manager;
using TheLight_ECommerce.Model;
using TheLight_ECommerce.Manager.Interface;
using System.Collections.Generic;
using System.Text;

namespace TheLight_ECommerce.Menus
{
    public class StaffMenu
    {
        ProductManager productManager = new ProductManager();
        StaffManager staffManager = new StaffManager();
        UserManager userManager = new UserManager();

        public  void Menu(User user)
        {
            var exit = false;

            while (!exit)
            {
               /* Console.Clear();*/
                PrintStaffMenu();
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
                            userManager.ViewWallet(user);
                            break;
                        case 4:
                            userManager.AddMoneyToWallet(user);
                            break;
                        case 0:
                            exit = true;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Input, please try again....");
                            Console.ResetColor();
                            break;
                    }
                }
            }
        }

        public void PrintStaffMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1.\tView all products");
            Console.WriteLine("2.\tAdd Product");
            Console.WriteLine("3.\tView wallet");
            Console.WriteLine("4.\tAdd money to wallet");
            Console.WriteLine("0.\tExit");
        }
    }
}

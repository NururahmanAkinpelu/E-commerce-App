using System;
using TheLight_ECommerce.Model;
using TheLight_ECommerce.Manager;
using TheLight_ECommerce.Manager.Interface;
using System.Collections.Generic;
using System.Text;
using TheLight_ECommerce.Enums;

namespace TheLight_ECommerce.Menus
{
    public class CustomerMenu
    {
        
        OrderManager orderManager = new OrderManager();
        UserManager userManager = new UserManager();
        /*MainMenu mainMenu = new MainMenu();*/
        

        public void Menu(User user)
        {
            var exit = false;

            while (!exit)
            {
                /*Console.Clear();*/
                PrintCustomerMenu();
                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            orderManager.MakeOrder();
                            break;
                        case 2:
                            userManager.ViewWallet(user);
                            break;
                        case 3:
                            userManager.AddMoneyToWallet(user);
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
        
        public void PrintCustomerMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1.\tMake order");
            Console.WriteLine("2.\tView wallet");
            Console.WriteLine("2.\tAdd money to wallet");
            Console.WriteLine("0.\tExit.");
        }       
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TheLight_ECommerce.Manager;

namespace TheLight_ECommerce.Menus
{
    public  class MainMenu
    {
        UserMenu userMenu = new UserMenu();
        CustomerManager customerManager = new CustomerManager();


        public void Menu()
        {
            var exit = false;

            while (!exit)
            {                
                /*Console.Clear();*/
                PrintMenu();
                int opt;
                if (int.TryParse(Console.ReadLine(), out opt))
                {
                    switch (opt)
                    {
                        case 1:
                            customerManager.RegisterCustomer();
                            break;
                        case 2:
                            userMenu.UserLogin();
                            break;
                        case 0:
                            exit = true;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid inpute...\nPress any key to try again...");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                    }
                }

            }
        }

        private  void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>");
            Console.WriteLine("<<<  Welcome to The Light Store >>>");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("1.\tRegister");
            Console.WriteLine("2.\tLogin");
            Console.WriteLine("0.\tExit.");
        }

    }
}

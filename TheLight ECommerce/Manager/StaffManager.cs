using System;
using TheLight_ECommerce.Manager.Interface;
using TheLight_ECommerce.Model;
using TheLight_ECommerce.Enums;
using System.Collections.Generic;
using System.Text;
using TheLight_ECommerce.Menus;

namespace TheLight_ECommerce.Manager
{
    public class StaffManager:IStaffManager
    {
        
        public static int NoOfStaffs = 2;        
       
        public void RegisterStaff()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phone = Console.ReadLine();
                       
            NoOfStaffs++;
            var role = Role.Staffs;

            decimal wallet = 500000;

            var staffNo = $"ST{NoOfStaffs.ToString("000")}";

            var newStaff = new Staff(NoOfStaffs,staffNo, firstName, lastName, email, password, phone, wallet, role);

            UserManager.users.Add(newStaff);
            Console.WriteLine($"You have successfully added a new staff with staff number {newStaff.StaffNo}.");

        }
        public void ViewAllStaffs()
        {
            
            foreach (var item in UserManager.users)
            {
                if (item.Role == Role.Staffs)
                {
                    Console.WriteLine(item);
                }
            }
        }
       /* public void RemoveStaff()
        {

        }*/

    }
    
}

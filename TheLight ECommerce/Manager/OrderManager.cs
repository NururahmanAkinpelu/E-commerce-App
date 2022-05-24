using System;
using TheLight_ECommerce.Model;
using TheLight_ECommerce.Enums;
using System.Collections.Generic;
using System.Text;

namespace TheLight_ECommerce.Manager
{
    public class OrderManager
    {
        public static int NoOfOrder = 0;
        static List<Order> Orders = new List<Order>();
        ProductManager productManager = new ProductManager();
        CustomerManager customerManager = new CustomerManager();
        

        public void MakeOrder()
        {
            productManager.GetAllProducts();
            Dictionary<string, int> cart = new Dictionary<string, int>();
            NoOfOrder++;
            var listOfProduct = ProductManager.products;
            bool flag = true;

            Console.Write("Enter your ID: ");
            int id = int.Parse(Console.ReadLine());
            var customer = customerManager.GetCustomerById(id);
            string customerName = customer.FirstName;
            
            while (flag)
            {
                
                for(int i = 0; i<listOfProduct.Count; i++)
                {
                    Console.WriteLine($"Enter {listOfProduct[i].ProductId} to order {listOfProduct[i].ProductName}");
                    
                }

                var prd = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the quantity to order");
                var qty = int.Parse(Console.ReadLine());

                var asd = listOfProduct[prd].ProductName;

                if (cart.ContainsKey(asd))
                {
                    cart[asd] += qty;
                }

                else
                {
                    cart.Add(listOfProduct[prd].ProductName, qty);
                }

                Console.WriteLine("do you still want to add to cart, y/n");
                char opt = char.Parse(Console.ReadLine());
                if(opt.ToString().ToUpper() == "N")
                {
                    flag = false;

                }

                else if(opt.ToString().ToUpper() == "Y")
                {
                    flag = true;
                }
            }

            decimal totalAmount = 0;

            foreach (var item in cart)
            {
                totalAmount += item.Value * productManager.GetProductsByName(item.Key).ProductAmount;
            }

            Console.WriteLine($"ITEM\tQUANTITY\tPRICE");
            foreach (var item in cart)
            {
                
                Console.WriteLine($"{item.Key}\t{item.Value}\t{productManager.GetProductsByName(item.Key).ProductAmount * item.Value}");
            }
            Console.WriteLine("You've successfully made  an order \nYou total amount is {0}", totalAmount);

            Order order = new Order(NoOfOrder,id, customerName, cart, totalAmount);
            Orders.Add(order);

            Console.WriteLine("Enter 1 to proceed to payment: ");
            var response = int.Parse(Console.ReadLine());
            if(response == 1)
            {
                customer.Wallet -= order.TotalAmount;
            }
            
            if (order.TotalAmount > customer.Wallet) Console.WriteLine("You have insufficient money walllet, please add money to yoyr wallet");
            else Console.WriteLine($"transaction successul, {totalAmount} has been deducted from your wallet ");
            
            

            Console.Write("Enter 1 to check your wallet balance: ");
            int check = int.Parse(Console.ReadLine());
            if (check == 1)
            {
                Console.WriteLine($"Your balance is {customer.Wallet}");
            }           
        }      
    }
}

using TheLight_ECommerce.Model;
using TheLight_ECommerce.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using TheLight_ECommerce.Manager.Interface;

namespace TheLight_ECommerce.Manager
{
    class ProductManager : IProductManager
    {
        public static int NoOfProduct = 10;
        public static List<Product> products = new List<Product>()
        {
            new Product(1, "Biscuit", 200, 50),
            new Product(2, "Chocolate", 300, 50),
            new Product(3, "Snickers", 10000, 20),
            new Product(4, "Laptop", 100000, 15),
            new Product(5, "Phone", 50000, 20),
            new Product(6, "Shirt", 2000, 30),
            new Product(7, "Cap", 1000, 40),
            new Product(8, "Earphone", 5000, 20),
            new Product(9, "Book", 1500, 30),
            new Product(10, "Television", 100000, 25)
        };


        public  void AddProduct()
        {
            NoOfProduct++;
         
            Console.Write("Enter product's name: ");
            string productName = Console.ReadLine();
            Console.Write("Enter amount of the product: ");
            decimal productAmount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            int productQuantity = int.Parse(Console.ReadLine());

            Product product = new Product(NoOfProduct, productName, productAmount, productQuantity);
            products.Add(product);

            Console.WriteLine("You've successfully added a product.");
        }

        /*public void RemovePrduct()
        {
            NoOfProduct--;
           
            Console.Write("Enter product's Id: ");
            int productId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product quantity: ");
            int productQuantity = int.Parse(Console.ReadLine());

            Product product = new Product(pro, productQuantity);
            products.Remove(product);

            Console.WriteLine("You've successfully removed a product: ");
        }*/

        public void PrintProduct(Product product)
        {
            Console.WriteLine($"{product.ProductId}\t{product.ProductName}\t{product.ProductAmount}");
        }

        public void GetAllProducts()
        {
            Console.WriteLine("ID\tPRODUCT\tPRICE");
            foreach (var product in products)
            {

                Console.WriteLine($"{product.ProductId}\t{product.ProductName}\t{product.ProductAmount}");
            }
            /*if (count == 0) Console.WriteLine("Sorry  there is no product yet...");*/
            
        }

        public Product GetProductsByName(string productName)
        {
            foreach (var product in products)
            {
                if (product.ProductName == productName)
                {
                    return product;
                }
            }
            return null;
        }

        public void SearchProductsByName(string productName)
        {
            int count = 0;
            foreach (var product in products)
            {
                if (product.ProductName == productName)
                {
                    PrintProduct(product);
                    count++;
                }
                else Console.WriteLine("Sorry product not found...");
            }
        }

        public void GetProductById(int productId)
        {
            int count = 0;
            foreach (var product in products)
            {
                if (product.ProductId == productId)
                {
                    PrintProduct(product);
                    count++;
                }
                else Console.WriteLine("Sorry product not found...");
            }
        }

        void IProductManager.GetProductsByName(string productname)
        {
            throw new NotImplementedException();
        }
    }
}

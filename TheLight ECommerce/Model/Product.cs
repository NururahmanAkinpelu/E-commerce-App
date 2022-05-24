using System;
using System.Collections.Generic;
using System.Text;

namespace TheLight_ECommerce.Model
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductAmount { get; set; }
        public int ProductQuantity { get; set; }

        public Product(int productId, string productName, decimal productAmount, int productQuantity)
        {
            ProductId = productId;
            ProductName = productName;
            ProductAmount = productAmount;
            ProductQuantity = productQuantity;
        }
    }
}

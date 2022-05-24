using System;
using System.Collections.Generic;
using System.Text;

namespace TheLight_ECommerce.Model
{
    class Order
    {

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }       
        public Dictionary<string, int> Cart { get; set; } = new Dictionary<string, int>();
        public decimal TotalAmount { get; set; }

        public Order(int orderId,int customerId, string customerName, Dictionary<string, int> cart, decimal totalAmount)
        {
            OrderId = orderId;
            CustomerId = customerId;
            CustomerName = customerName;
            Cart = cart;
            TotalAmount = totalAmount;                       
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TheLight_ECommerce.Model;

namespace TheLight_ECommerce.Manager.Interface
{
    public interface IProductManager
    {
        public void AddProduct();
        public void GetProductById(int id);
        public void GetProductsByName(string productname);
    }
}

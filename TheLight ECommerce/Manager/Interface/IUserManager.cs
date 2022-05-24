using System;
using System.Collections.Generic;
using System.Text;
using TheLight_ECommerce.Model;

namespace TheLight_ECommerce.Manager.Interface
{
    public interface IUserManager
    {
        public User Login(string email, string password);
        public User GetUserByEmail(string email);
        public List<User> ViewAllUsers();
        public void ViewWallet(User user);
        
    }
}

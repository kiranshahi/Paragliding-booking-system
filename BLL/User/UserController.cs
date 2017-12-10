using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class UserController
    {
        public void AddUpdateUser(User user)
        {
            UserProvider provider = new UserProvider();
            provider.AddUpdateUser(user);
        }
    }
}

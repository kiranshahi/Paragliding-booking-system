using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserProvider
    {
        public void AddUpdateUser(User user)
        {
            SqlHandler handler = new SqlHandler();
            List<KeyValuePair<string, object>> param = new List<KeyValuePair<string, object>>();
            param.Add(new KeyValuePair<string, object>("@Username", user.UserName));
            param.Add(new KeyValuePair<string, object>("@FirstName", user.FirstName));
            param.Add(new KeyValuePair<string, object>("@MiddleName", user.MiddleName));
            param.Add(new KeyValuePair<string, object>("@LastName", user.LastName));
            param.Add(new KeyValuePair<string, object>("@Email", user.Email));
            param.Add(new KeyValuePair<string, object>("@PhoneNumber", user.PhoneNumber));
            param.Add(new KeyValuePair<string, object>("@Address", user.Address));
            param.Add(new KeyValuePair<string, object>("@UserRoleID", user.UserRoleID));

            handler.ExecuteNonQuery("AddUpdateUser", param);
        }
    }
}

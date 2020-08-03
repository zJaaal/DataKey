using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool Loginuser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        Register register = new Register();
        public bool RegisterInfo(string Identity)
        {
            return register.RegisterData(Identity);
        }
    }
}

        
            
}

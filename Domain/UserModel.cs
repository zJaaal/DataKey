using DataAccess;
using System;
using System.Data;

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

        Instructions Ins = new Instructions();
        public bool Update(string Identity, string Position, string Name, string Last_Name, string Access_Level, string KeyPass)
        {
            var UpdateMaker = register.RegisterData(Identity);
            var ID = Convert.ToInt32(Identity);
            if (UpdateMaker == true)
            {
                Ins.UpdateQuery(ID, Position, Name, Last_Name, Access_Level, KeyPass);
                return true;
            }
            else
            {
                Ins.ADDQuery(ID, Position, Name, Last_Name, Access_Level, KeyPass);
                return false;
            }

        }
        public bool UpdateGuard(string Identity, string Position, string Name, string Last_Name, string Access_Level, string KeyPass)
        {
            var UpdateMaker = register.RegisterData(Identity);
            var ID = Convert.ToInt32(Identity);
            if (UpdateMaker == true)
            {
                Ins.UpdateQuery(ID, Position, Name, Last_Name, Access_Level, KeyPass);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool EraseAdvice(string Identity)
        {
            var Erase = register.RegisterData(Identity);
            if (Erase == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Erase(string Identity)
        {
            Ins.EraseQuery(Convert.ToInt32(Identity));
        }

        public DataTable ShowEmployees()
        {
            DataTable _EmployeesInfo = new DataTable();
            _EmployeesInfo = Ins.ShowQuery();
            return _EmployeesInfo;
        }
    }
}

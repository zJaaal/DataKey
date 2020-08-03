using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserDao : ConnectionToSQL
    {
        public bool Login(string user, string pass)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    /*Remember to change the name of YOUR table in the code below*/
                    command.CommandText = "select *from EmployeesInfo where ID =@user and KeyPass=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        
                        while (reader.Read())
                        {
                            UserLoginCache.userID = reader.GetInt32(0);
                            UserLoginCache.userPosition = reader.GetString(1);
                            UserLoginCache.userName = reader.GetString(2);
                            UserLoginCache.userLastName = reader.GetString(3);
                            UserLoginCache.userAccessLevel = reader.GetString(4);
                            UserLoginCache.userKeyPass = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
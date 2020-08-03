using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Common;
using Common.Cache;

namespace DataAccess
{
   public class Register : ConnectionToSQL
   {
        public bool RegisterData(string Identity)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Command = new SqlCommand())
                { //Be sure to change it to your DataBase Names
                    Command.Connection = connection;
                    Command.CommandText = "select *from EmployeesInfo where ID = @Identification";
                    Command.Parameters.AddWithValue("@Identification", Identity);
                    Command.CommandType = CommandType.Text;
                    SqlDataReader reader = Command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                        RegisterCache.userID = reader.GetInt32(0);
                        RegisterCache.userPosition = reader.GetString(1);
                        RegisterCache.userName = reader.GetString(2);
                        RegisterCache.userLastName = reader.GetString(3);
                        RegisterCache.userAccessLevel = reader.GetString(4);
                        RegisterCache.userKeyPass = reader.GetString(5);
                        }
                      
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
   }
}

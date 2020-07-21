using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSQL
    {
        private readonly string connectionString;
        public ConnectionToSQL()
        {       /* You must change this code for using on another SQL Server DataBase, change only the "server" and "DataBase" strings and be sure to read the Table.txt*/
            connectionString = @"Server=ANA\SQLEXPRESS01;DataBase=Employees; integrated security = true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);

        }
    }
}

using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Instructions : ConnectionToSQL
    {
        public void ADDQuery(int Identity, string Position, string Name, string Last_Name, string Access_Level, string KeyPass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Command = new SqlCommand())
                { //Be sure to change it to your DataBase Names
                    Command.Connection = connection;
                    Command.CommandText = "insert into EmployeesInfo values(" + Identity + ",'" + Position + "','" + Name + "','" + Last_Name + "','" + Access_Level + "','" + KeyPass + "')";
                    Command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void UpdateQuery(int Identity, string Position, string Name, string Last_Name, string Access_Level, string KeyPass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Command = new SqlCommand())
                { //Be sure to change it to your DataBase Names
                    Command.Connection = connection;
                    Command.CommandText = "update EmployeesInfo set Position='" + Position + "', Name='" + Name + "', Last_Name='" + Last_Name + "', Access_Level='" + Access_Level + "', KeyPass='" + KeyPass + "'where id='" + Identity + "'";
                    Command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void EraseQuery(int Identity)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Command = new SqlCommand())
                { //Be sure to change it to your DataBase Names
                    Command.Connection = connection;
                    Command.CommandText = "delete  from EmployeesInfo where id='" + Identity + "'";
                    Command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public DataTable ShowQuery()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Command = new SqlCommand())
                { //Be sure to change it to your DataBase Names
                    Command.Connection = connection;
                    Command.CommandText = "Select *from EmployeesInfo";
                    Command.ExecuteNonQuery();

                    DataTable _EmployeesTable = new DataTable();

                    SqlDataReader Read;
                    Read = Command.ExecuteReader();

                    _EmployeesTable.Load(Read);

                    connection.Close();

                    return _EmployeesTable;
                }
            }
        }
    }
}

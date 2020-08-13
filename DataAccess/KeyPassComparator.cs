using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    public class KeyPassComparator : ConnectionToSQL
    {
        public bool KPSearch(string KP)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    /*Remember to change the name of YOUR table in the code below*/
                    command.CommandText = "select *from EmployeesInfo where KeyPass =@KeyPass";
                    command.Parameters.AddWithValue("@KeyPass", KP);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                        connection.Close();
                    return false;

                }
            }
        }
    }
}

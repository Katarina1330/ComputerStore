using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    public class DataAccess
    {
        public static void ReadAllEmployees()
        {
            try
            {
                // var conn = new SqlConnection();
                // Kreiramo konekciju
                SqlConnection conn = new SqlConnection(
                    Properties.Settings.Default.ComputerStoreConnectionString);
                // Otvaramo konekciju:
                conn.Open();

                // Kreiramo komandu:
                SqlCommand cmd = new SqlCommand("select * from employees", conn);

                // Izvrsavamo komandu:
                cmd.ExecuteReader();
                // SqlDataReader <-> ResultSet
                //... 

                // Zatvaramo konekciju:
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("greska: " + ex.Message);
            }
        }
    }
}

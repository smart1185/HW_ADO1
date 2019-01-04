using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Con_SqlClient
{
    class Program
    {
        static string connectionString;

        static Program()
        {
            connectionString = @"Data Source = LAPTOP-NSMJD0QF\SQLEXPRESS; Initial Catalog=MCS; Integrated Security=True;";
        }

        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            
            try
            {
                con.Open();
                Console.WriteLine("Connection opened");
                Console.WriteLine("Connection string - {0}, Database Name - {1}, Sever Name - {2}, Server version - {3}, State - {4}, Timeout - {5}", con.ConnectionString, con.Database, con.DataSource, con.ServerVersion, con.State, con.ConnectionTimeout);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
                Console.WriteLine("Connection closed");
            }


            Console.Read();
        }
    }
}

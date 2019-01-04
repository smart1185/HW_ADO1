using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoProjectHW_Sql
{
    public class Program
    {
        static string connectionString;

        static Program()
        {
            connectionString = @"Data Source = LAPTOP-NSMJD0QF\SQLEXPRESS; Initial Catalog=MCS; Integrated Security=True;";
        }
        static void Main(string[] args)
        {
        }

        public static void SqlConnect()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;


            try
            {
                con.Open();
                Console.WriteLine("SqlConnection opened");
                Console.WriteLine(" Connection string - {0},\n Database Name - {1},\n Sever Name - {2},\n Server version - {3},\n State - {4},\n Timeout - {5}\n",
                    con.ConnectionString, con.Database, con.DataSource, con.ServerVersion, con.State, con.ConnectionTimeout);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
                Console.WriteLine("SqlConnection closed");
            }
        }
    }
}

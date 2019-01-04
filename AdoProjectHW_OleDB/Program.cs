using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace AdoProjectHW_OleDB
{
    public class Program
    {
        static string connectionString;

        static Program()
        {
            connectionString = @"Provider=SQLOLEDB; Data Source = MCS; Integrated Security =SSPI;";
        }
        static void Main(string[] args)
        {
            OleDBConnect();
        }

        public static void OleDBConnect()
        {
            // string connectionString = ConfigurationManager.ConnectionStrings["EntityModel"].ConnectionString;
            //OleDbConnection ocon = new OleDbConnection("Provider=SQLOLEDB;" + @"Server=LAPTOP-NSMJD0QF\SQLEXPRESS;" + "Database=MCS;" + "Integrated Security=True;" );
            OleDbConnection ocon = new OleDbConnection();
            ocon.ConnectionString = connectionString;

            try
            {
                ocon.Open();
                Console.WriteLine("OleDBConnection opened");
                Console.WriteLine(" Connection string - {0},\n Database Name - {1},\n Sever Name - {2},\n Server version - {3},\n State - {4},\n Timeout - {5}\n",
                    ocon.ConnectionString, ocon.Database, ocon.DataSource, ocon.ServerVersion, ocon.State, ocon.ConnectionTimeout);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ocon.Close();
                Console.WriteLine("OleDBConnection closed");
            }
        }
    }
}

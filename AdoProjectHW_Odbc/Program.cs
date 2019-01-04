using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace AdoProjectHW_Odbc
{
    public class Program
    {
        static string connectionString;

        static Program()
        {
            connectionString = @"Driver={SQL Server}; Server=LAPTOP - NSMJD0QF\SQLEXPRESS; Trusted_Connection=yes; Database=MCS;";
        }
      

        static void Main(string[] args)
        {
        }

        public static void ODBConnect()
        {          
            OdbcConnection odb = new OdbcConnection();
            odb.ConnectionString = connectionString;

            try
            {
                odb.Open();
                Console.WriteLine("OdbcConnection opened");
                Console.WriteLine(" Connection string - {0},\n Database Name - {1},\n Sever Name - {2},\n Server version - {3},\n State - {4},\n Timeout - {5}\n",
                    odb.ConnectionString, odb.Database, odb.DataSource, odb.ServerVersion, odb.State, odb.ConnectionTimeout);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                odb.Close();
                Console.WriteLine("OdbcConnection closed");
            }
        }
    }
}

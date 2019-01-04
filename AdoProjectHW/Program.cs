using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AdoProjectHW
{
    class Program
    {        
        static void Main(string[] args)
        {
            #region SqlClient
            AdoProjectHW_Sql.Program.SqlConnect();
            
            #endregion

            #region OleDBClient

            AdoProjectHW_OleDB.Program.OleDBConnect();

            #endregion

            #region Odbc
            AdoProjectHW_Odbc.Program.ODBConnect();
            #endregion

            Console.Read();
        }
    }
}

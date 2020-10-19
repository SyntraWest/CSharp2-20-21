using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;

namespace TodoCrudConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = File.ReadAllText("connectionstring.txt");

            using(DbConnection connection = new SqlConnection(connectionString))
            {

            }
        }
    }
}

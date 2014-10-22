using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write a program that retrieves from the Northwind sample database in MS SQL Server the number of  rows in the Categories table.

namespace RetreiveCatFromNorthwind
{
    class RetreiveCatFromNorthwind
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=NINA; " +
           "Database=Northwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand cmdGetNumberCategories = new SqlCommand(
                    "SELECT COUNT(*) FROM Categories", dbCon);

                int categoriesNumber = (int)cmdGetNumberCategories.ExecuteScalar();

                Console.WriteLine("The number of categories is {0}.", categoriesNumber);
            }
        }
    }
}

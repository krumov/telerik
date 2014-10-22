using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//03. Write a program that retrieves from the Northwind database all product categories
//and the names of the products in each category. Can you do this with a single SQL query (with table join)?

namespace GetsCategoriesAndProductsInThem
{
    class GetsCategoriesAndProductsInThem
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=NINA; " +
            "Database=Northwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand cmdGetCategoriesAndProductsInThem = new SqlCommand(
                    "SELECT c.CategoryName, p.ProductName FROM Categories c " +
                    "JOIN Products p " +
                    "ON c.CategoryID = p.CategoryID " +
                    "GROUP BY c.CategoryName, p.ProductName", dbCon);

                SqlDataReader reader = cmdGetCategoriesAndProductsInThem.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine
                            ("Category: {0}; Product: {1}",
                            (string)reader["CategoryName"],
                            (string)reader["ProductName"]);
                    }
                }
            }
        }
    }
}

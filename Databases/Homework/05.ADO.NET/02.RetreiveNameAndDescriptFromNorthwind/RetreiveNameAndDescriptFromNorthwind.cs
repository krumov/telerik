using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that retrieves the name and description of all categories in the Northwind DB.

namespace RetreiveNameAndDescriptFromNorthwind
{
    class RetreiveNameAndDescriptFromNorthwind
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=NINA; " +
          "Database=Northwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand cmdGetNameAndDescrCategories = new SqlCommand(
                    "SELECT CategoryName, Description FROM Categories", dbCon);

                SqlDataReader reader = cmdGetNameAndDescrCategories.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine
                            ("Name: {0}; Descrpiption: {1}",
                            (string)reader["CategoryName"],
                            (string)reader["Description"]);
                    }
                }
            }
        }
    }
}

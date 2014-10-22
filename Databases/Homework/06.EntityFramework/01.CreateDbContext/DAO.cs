using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateDbContext
{
    public class DAO  // Tasks 1-5
    {
        static void Main()
        {
            //Edit("ALFKI", "Plamen");
            //Add("GRIVICA", "T233I");

            FindSales("WA", new DateTime(1997, 01, 01), new DateTime(1997, 06, 06));
        }

        // TASK 2
        // Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers.
        // Write a testing class.


        static void Add(string name, string id)
        {
            Customer newCustomer = new Customer()
            {
                CompanyName = name,
                CustomerID = id
            };

            using (NorthwindEntities db = new NorthwindEntities())
            {
                bool isInDB = IsInDataBase(db, id);

                if (!isInDB)
                {
                    db.Customers.Add(newCustomer);
                    db.SaveChanges();
                    Console.WriteLine("Added Successful.");
                }
                else
                {
                    throw new ArgumentException("Such customer already exists");
                }
            }
        }

        static void Edit(string id, string newContactName)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var customer = db.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
                customer.ContactName = newContactName;
                db.SaveChanges();
            }
        }

        static void Delete(string id)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var customer = db.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }

        static bool IsInDataBase(NorthwindEntities db, string id)
        {
            bool alreadyInDB = db.Customers.Where(a => a.CustomerID == id).Any();
            return alreadyInDB;
        }

        // TASK 3 
        // Write a method that finds all customers who have orders made in 1997 and shipped to Canada.

        static void FindAllCustomers(int orderDate, string shipDestination)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var orders = from order in db.Orders
                             where order.OrderDate.Value.Year == orderDate && order.ShipCountry == shipDestination
                             select order;

                foreach (var item in orders)
                {
                    Console.WriteLine("Order made by: {0} with CustomerId: {1}", item.Customer.ContactName, item.Customer.CustomerID);
                }
            }
        }

        // TASK 4
        // Implement previous by using native SQL query and executing it through the DbContext.

        static void FindAllCustomersWithNativeSQLQuery(int orderDate, string country)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                string sqlQuery = @"SELECT c.ContactName from Customers" +
                                  " c INNER JOIN Orders o ON o.CustomerID = c.CustomerID " +
                                  "WHERE (YEAR(o.OrderDate) = {0} AND o.ShipCountry = {1});";

                object[] parameters = { orderDate, country };
                var sqlQueryResult = db.Database.SqlQuery<string>(sqlQuery, parameters);

                foreach (var order in sqlQueryResult)
                {
                    Console.WriteLine(order);
                }
            }
        }

        // TASK 5
        // Write a method that finds all the sales by specified region and period (start / end dates).
        static void FindSales(string region, DateTime from, DateTime to)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var askedSales = db.Orders.Where(o => o.ShipRegion == region && o.OrderDate > from && o.OrderDate < to)
                                          .Select(o => new { ShipName = o.ShipName, OrderDate = o.OrderDate });

                foreach (var item in askedSales)
                {
                    Console.WriteLine(item.ShipName + " was shiped on: " + item.OrderDate);
                }
            }
        }
    }
}

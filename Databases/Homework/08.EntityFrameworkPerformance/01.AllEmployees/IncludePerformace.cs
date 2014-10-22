using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AllEmployees
{
    // Using Entity Framework write a SQL query to select all employees from the Telerik Academy database
    // and later print their name, department and town. Try the both variants: with and without .Include(…). 
    // Compare the number of executed SQL statements and the performance.

    class IncludePerformace
    {
        static void Main(string[] args)
        {
            var dbContext = new TelerikAcademyEntities();

            using (dbContext)
            {

                // over 300 selects
                foreach (var employee in dbContext.Employees)
                {
                    Console.WriteLine(employee.FirstName + ": " +
                        employee.Department.Name + ", " +
                        employee.Address.Town.Name);
                }

                Console.WriteLine();
                // 1 select (with alot of joins) :)
                foreach (var employee in dbContext.Employees.Include("Department").Include("Address.Town"))
                {
                    Console.WriteLine(employee.FirstName + ": " +
                    employee.Department.Name + ", " +
                    employee.Address.Town.Name);
                }

                /*
                 TASK 2 
                 * Using Entity Framework write a query that selects all employees from the Telerik Academy 
                 * database, then invokes ToList(), then selects their addresses, then invokes ToList(), 
                 * then selects their towns, then invokes ToList() and finally checks whether the town is
                 * "Sofia". Rewrite the same in more optimized way and compare the performance.
                 */

                //var allEmployees = dbContext.Employees.ToList()
                //                          .Select(e => e.Address).ToList()
                //                          .Select(e => e.Town).ToList()
                //                          .Where(e => e.Name == "Sofia");

                var allEmployeesOptimized = dbContext.Employees
                                                   .Select(e => e.Address)
                                                   .Select(e => e.Town)
                                                   .Where(e => e.Name == "Sofia").ToList();

                // Just run the SQL Profiler - the unoptimized allEmplyees makes about 1200 selects 
                // vs the optimized which only makes one select query :)

            }

        }
    }
}

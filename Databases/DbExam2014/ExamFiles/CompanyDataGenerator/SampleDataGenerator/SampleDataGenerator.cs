using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data;

namespace SampleDataGenerator
{
    class SampleDataGenerator
    {
        static void Main(string[] args)
        {
            var random = RandomDataGenerator.Instance;
            var db = new CompanyEntities();
            db.Configuration.AutoDetectChangesEnabled = false;

            Console.WriteLine("\nAdding departments");

            for (int i = 0; i < 100; i++)
            {
                var department = new Department
                {
                    Name = random.GetRandomStringWithRandomLength(10,50)
                };

                db.Departments.Add(department);

                if (i%100 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                }
            }
            db.SaveChanges();
            Console.WriteLine("\nDepartents added");

            Console.WriteLine("\nAdding employees");

            var departmentIds = db.Departments.Select(d => d.Id).ToList();
            for (int i = 0; i < 5000; i++)
			{
			  var employee = new Employee
                {
                    FirstName = random.GetRandomStringWithRandomLength(5,20),
                    LastName = random.GetRandomStringWithRandomLength(5,20),
                    DepartmentId = departmentIds[random.GetRandomNumber(0, departmentIds.Count - 1)],
                    YearSalary = random.GetRandomNumber(50000,200000),
                    ManagerId = (i > 250) ? i - 1 :(int?)null // 4750 employees will have a manager (95%) :) 
                                                                  // it is very stupid i know but I left it for last and forgot it                    
                };
                
              db.Employees.Add(employee);

              if (i % 100 == 0)
              {
                  Console.Write(".");
                  db.SaveChanges();
              }
            }
            db.SaveChanges();
            Console.WriteLine("\nEmployees added");

            Console.WriteLine("\nAdding Projects"); //For some reason it does not want to work
            var employeeIds = db.Employees.Select(e => e.Id).ToList();
            for (int i = 0; i < 1000; i++)
            {
                var project = new Project
                {
                    Name = "Project" + i.ToString(),       
                };

                var count = random.GetRandomNumber(5, 20);

                for (int j = 0; j < count; j++)
                {
                    var projectEmployee = new ProjectsEmployee
                    {
                        EmployeeId = employeeIds[i+j],
                        ProjectId = i+1,
                        StartDate = new DateTime(random.GetRandomNumber(1980, 2005), random.GetRandomNumber(1, 12), random.GetRandomNumber(1, 28)),
                        EndDate = new DateTime(random.GetRandomNumber(2005, 2020), random.GetRandomNumber(1, 12), random.GetRandomNumber(1, 28))
                        
                    };

                    project.ProjectsEmployees.Add(projectEmployee);
                }
                

                db.Projects.Add(project);

                if (i % 100 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                }
            }
            db.SaveChanges();
            Console.WriteLine("\nProjects added");


            Console.WriteLine("\nAdding Reports");
            var employeeIds2 = db.Employees.Select(d => d.Id).ToList();
            for (int i = 0; i < 5000; i++)
            {
                var empId = employeeIds2[i];

                for (int j = 0; j < 50; j++) // every empolyee gets 50 reports
			    {
			        var report = new Report
                    {
                        EmployeeId = empId,
                        TimeOfReport = new DateTime(random.GetRandomNumber(1980, 2014), random.GetRandomNumber(1, 12), random.GetRandomNumber(1, 28))
                    };
                    db.Reports.Add(report);
                }
                Console.Write(".");
                db.SaveChanges();
                
            }
            db.SaveChanges();
            Console.WriteLine("\nReports added");

            
            db.Configuration.AutoDetectChangesEnabled = true;
        }
    }
}

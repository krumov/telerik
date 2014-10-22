using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Task2
{
    public class Worker : Human
    {
        public int weekSalary { get; set; }
        public int workHoursPerDay { get; set; }


        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }
        public int MoneyPerHour(int weekSalary, int workHoursPerDay)
        {
            return weekSalary / (workHoursPerDay*5);
        }

    }
}

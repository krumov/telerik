using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Task2
{
    public class Student : Human
    {
        public int grade { get; set; }

        public Student(string firstName, string lastName , int grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }
    }
}

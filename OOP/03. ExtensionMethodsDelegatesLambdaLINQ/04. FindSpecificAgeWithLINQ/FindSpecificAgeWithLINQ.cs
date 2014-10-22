using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindSpecificAgeWithLINQ
{
    class FindSpecificAgeWithLINQ
    {
        public static List<Student> SortStudents(List<Student> students)
        {
            var sortedStudents =
                from student in students
                where student.Age < 25 && student.Age > 18
                select student;

            return sortedStudents.ToList();
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan","Petrov", 18),
                new Student("Angel","Ivanov", 25),
                new Student("Ivan","Angelov", 22),
                new Student("Ivan","Boikov", 23)
            };

            var sortedStudents = SortStudents(students);
            
            //Exercise 4
            Console.WriteLine("Only student with age between 18 and 25 (not including)\n");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }


            //Exercise5
            // With lambda
            var sorted1 = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            // with LINQ
            var sorted2 = 
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine("\n\nStudents ordered descending by their names:\n");
            foreach (var student in sorted1) // change sorted1 to sorted2 to check if both are working
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
            }
            Console.WriteLine();
        }
    }
}

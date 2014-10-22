using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortArrayWithLINQ
{
    class SortArrayWithLINQ
    {

        public static List<Student> SortStudents(List<Student> students)
        {
            var sortedStudents =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            return sortedStudents.ToList();
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan","Petrov"),
                new Student("Angel","Ivanov"),
                new Student("Ivan","Angelov"),
                new Student("Ivan","Boikov")
            };

            var sortedStudents = SortStudents(students);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
            }
        }
    }
}

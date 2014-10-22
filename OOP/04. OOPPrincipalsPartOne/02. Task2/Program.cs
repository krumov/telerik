using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>()
            {
                new Student("Ivan","Ivanov",1),
                new Student("Petyr","Ivanov",4),
                new Student("Ivo","Petrov",3),
                new Student("Dancho","Krasimirov",2),
                new Student("Ivan","Krumov",10),
                new Student("Krum","Petrov",9),
                new Student("Asen","Tsvetanov",7),
                new Student("Tsvetan","Petrov",6),
                new Student("Petyr","Ivailov",5),
                new Student("Pesho","Ruskov",8),
            };

           var sortedStudents = students.OrderBy(s => s.grade).ToList();


            List<Worker> workers = new List<Worker>() 
            {
                new Worker("Ivan","Ivanov",400,8),
                new Worker("Petyr","Ivanov",350,8),
                new Worker("Ivo","Petrov",500,4),
                new Worker("Dancho","Krasimirov",600,8),
                new Worker("Ivan","Krumov",400,6),
                new Worker("Krum","Petrov",500,6),
                new Worker("Asen","Tsvetanov",1000,8),
                new Worker("Tsvetan","Petrov",2000,8),
                new Worker("Petyr","Ivailov",800,6),
                new Worker("Pesho","Ruskov",450,6),
            };

            var sortedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour(worker.weekSalary,worker.workHoursPerDay));

            var mergedLists = workers.Concat<Human>(students).ToList();
            mergedLists = mergedLists.OrderBy(list => list.firstName).ThenBy(list => list.lastName).ToList();
        }
    }
}

using System;
using System.Collections.Generic;

namespace InheritanceAndPolymorphism
{
    class CoursesExamples
    {
        static void Main()
        {
            IList<Student> students = new List<Student>()
            {
                new Student("Peter"),
                new Student("Maria")
            };
            LocalCourse localCourse = new LocalCourse("Databases",
                new Teacher("Svetlin Nakov"), students, "Enterprise");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.Students.Add(new Student("Milena"));
            localCourse.Students.Add(new Student("Todor"));
            Console.WriteLine(localCourse);

            IList<Student> offsiteStudents = new List<Student>()
            {
                new Student("Thomas"),
                new Student("Ani"),
                new Student("Steve"),
            };
            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development", new Teacher("Mario Peshev"),
                offsiteStudents, "Burgas");
            Console.WriteLine(offsiteCourse);
        }
    }
}
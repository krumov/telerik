namespace SchoolProject.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseConstructorTestName()
        {
            string name = "Javascript";
            Course course = new Course(name);
            Assert.AreEqual(course.Name, "Javascript");
        }

        [TestMethod]
        public void CourseConstructorTestListStudents()
        {
            string name = "Javascript";
            Student maria = new Student("Maria Petrova", 12345);
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            course.AddStudent(maria);
            Assert.IsTrue(course.Students.Contains(maria));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestEmptyString()
        {
            string name = string.Empty;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        public void AddStudentTestOneStudent()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            course.AddStudent(maria);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        public void AddStudentTestTwoStudents()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            course.AddStudent(maria);
            course.AddStudent(petar);
            Assert.IsTrue(course.Students.Count == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentTestSameStudentTwoTimes()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            course.AddStudent(maria);
            course.AddStudent(maria);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudentTestMoreThanMaximumStudents()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            for (int i = 12345; i < 12375; i++)
            {
                 course.AddStudent(new Student("Maria Petrova", i));
            }            
        }

        [TestMethod]
        public void RemoveStudentTest()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            course.AddStudent(maria);
            course.AddStudent(petar);
            course.RemoveStudent(petar);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingStudentTest()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            course.RemoveStudent(maria);
        }

        [TestMethod]
        public void ToStringTestOneStudent()
        {
            string name = "Javascript";
            Student maria = new Student("Maria Petrova", 12345);
            IList<Student> students = new List<Student>();
            Course javascript = new Course(name, students);
            javascript.AddStudent(maria);
            string expected = "Course name Javascript; Student Maria Petrova, ID 12345; ";
            string actual;
            actual = javascript.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringTestTwoStudents()
        {
            string name = "Javascript";
            Student maria = new Student("Maria Petrova", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            IList<Student> students = new List<Student>();
            Course javascript = new Course(name, students);
            javascript.AddStudent(maria);
            javascript.AddStudent(petar);
            string expected = "Course name Javascript; Student Maria Petrova, ID 12345; Student Petar Marinov, ID 23445; ";
            string actual;
            actual = javascript.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentSystem.Data.Repositories;
using StudentSystem.Data;
using StudentSystem.Models;
using StudentSystem.WebHW.Models;

namespace StudentSystem.WebHW.Controllers
{
    public class StudentController : ApiController
    {
        private IGenericRepository<Student> students;

        public StudentController():this(new GenericRepository<Student>())
        {

        }

        public StudentController(IGenericRepository<Student> students)
        {
            this.students = students;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var students = this.students.All().Select(StudentModel.FromStudent);

            return Ok(students);
        }

        [HttpPost]
        public IHttpActionResult Create(StudentModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newStudent = new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Level = student.Level
            };

            this.students.Add(newStudent);
            this.students.SaveChanges();

            student.StudentIdentification = newStudent.StudentIdentification;

            return Ok(student);
        }

    }
}

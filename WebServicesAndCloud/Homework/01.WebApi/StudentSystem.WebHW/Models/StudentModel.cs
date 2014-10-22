using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace StudentSystem.WebHW.Models
{
    public class StudentModel
    {
        public static Expression<Func<Student, StudentModel>> FromStudent
        {
            get{
                return a => new StudentModel
                {
                    StudentIdentification = a.StudentIdentification,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Level = a.Level
                };
            }
        }

        public int StudentIdentification { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string LastName { get; set; }

        public int Level { get; set; }
 
    }
}
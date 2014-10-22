using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        private string name;
        private Teacher teacher;
        private IList<Student> students;

        public Course(string name, Teacher teacher, IList<Student> students)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Name too short");
                }
            }
        }

        public Teacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                if (value != null)
                {
                    this.teacher = value;
                }
                else
                {
                    throw new ArgumentException("Teacher can't be null");
                }
            }
        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value != null)
                {
                    if (value.Count > 0)
                    {
                        this.students = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Course should have at least one student");
                    }
                }
                else
                {
                    throw new ArgumentException("Students List can't be null");
                }
            }
        }

        private string GetStudentsAsString()
        {
            string studentsListAsString = "";
            for (int i = 0; i < this.Students.Count; i++)
            {
                studentsListAsString += this.Students[i].ToString();
                if (i < this.Students.Count - 1)
                {
                    studentsListAsString += ", ";
                }
            }

            return studentsListAsString;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(" { Name = ");
            result.Append(this.Name);

            result.Append("; Teacher = ");
            result.Append(this.Teacher.ToString());

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }
    }
}
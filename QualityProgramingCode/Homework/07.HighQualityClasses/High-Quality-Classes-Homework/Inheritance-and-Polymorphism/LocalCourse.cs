using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {

        private string lab;

        public LocalCourse(string courseName, Teacher teacher, IList<Student> students,
            string labName)
            : base(courseName, teacher, students)
        {
            this.Lab = labName;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (value.Length >= 2)
                {
                    this.lab = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Lab name too short");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse");
            result.Append(base.ToString());

            result.Append("; Lab = ");
            result.Append(this.Lab);

            result.Append(" }");
            return result.ToString();
        }
    }
}
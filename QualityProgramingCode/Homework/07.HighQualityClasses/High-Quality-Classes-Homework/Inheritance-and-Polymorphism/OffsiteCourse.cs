using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {

        private string town;

        public OffsiteCourse(string courseName, Teacher teacher, IList<Student> students,
            string townName)
            : base(courseName, teacher, students)
        {
            this.Town = townName;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (value.Length >= 2)
                {
                    this.town = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Tawn name too short");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse");
            result.Append(base.ToString());

            result.Append("; Town = ");
            result.Append(this.Town);

            result.Append(" }");
            return result.ToString();
        }
    }
}
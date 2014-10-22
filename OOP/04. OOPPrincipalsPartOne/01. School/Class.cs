using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Class : ICommentable
    {
        private string className;
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();

        public string ClassName 
        {
            get { return this.className; }
            set { this.className = value; }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }

        public List<Student> Students 
        {
            get { return this.students;}
            set { this.students = value; }
        }

        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }

    }
}

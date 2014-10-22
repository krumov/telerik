using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Teacher : Person, ICommentable
    {
        List<Discipline> disciplines = new List<Discipline>();

        public List<Discipline> Disciplines 
        {
            get { return this.disciplines; }
            set { this.disciplines = value; } 
        }

        public Teacher(string name)
        {
           this.Name = name;
        }

        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Student : Person, ICommentable
    {
        private int classNum;

        public int ClassNumber 
        {
            get { return this.classNum; } 
            set { this.classNum = value; } 
        }
     
        public Student(string name, int classNumber)
        {
            this.Name = name;
            this.ClassNumber = classNumber;
        }

        public List<string> Comments{get; set;}

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}

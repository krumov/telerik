using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Discipline : ICommentable
    {
        private string name;
        private int numOfLectures;
        private int numOfExercises;

        public Discipline(string Name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = Name;
            this.NumOfExercises = numberOfExercises;
            this.NumOfLectures = numberOfLectures;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int NumOfExercises 
        { 
            get { return this.numOfExercises; }
            set { this.numOfExercises = value; }
        }
        public int NumOfLectures
        {
            get { return this.numOfLectures; }
            set { this.numOfLectures = value; }
        }

        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}

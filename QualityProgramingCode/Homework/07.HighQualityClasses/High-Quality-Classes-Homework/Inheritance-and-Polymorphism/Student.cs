using System;

namespace InheritanceAndPolymorphism
{
    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.Name = name;
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
                    throw new ArgumentOutOfRangeException("Name should be at least two letters!");
                }
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
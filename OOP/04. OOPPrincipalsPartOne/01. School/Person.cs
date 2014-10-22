using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Person
    {
        private string name;

        public string Name 
        {
            get { return this.name;}
            set { this.name = value;} 
        }

        public Person()
        {

        }
        public Person(string name)
        {
            this.Name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class School
    {
        static void Main()
        {
        }

        private List<Class> classes = new List<Class>();

        public List<Class> Classes 
        {
            get { return this.classes;}
            set { this.classes = value;}
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person("Ivan", 36);
            Person per1 = new Person("Jhon", null);
            Person per2 = new Person("Pesho");
            Console.WriteLine(per);
            Console.WriteLine(per1);
            Console.WriteLine(per2);
        }
    }
}

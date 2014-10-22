using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// //Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.

namespace ReverseWithStack
{
    class ReverseWithStack
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            Console.Write("Enter a number or blank to end: ");

            string line = Console.ReadLine();

            int number;

            while (int.TryParse(line, out number))
            {
                numbers.Push(number);
                Console.Write("Enter a number or blank to end: ");
                line = Console.ReadLine();
            }

            Console.WriteLine("Reversed order : ");

            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}

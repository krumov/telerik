using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First50OfSequence
{
    class First50OfSequence
    {
        public static void Main()
        {
            Console.WriteLine("Insert a positive number for sequence:");
            int n = 0;
            while (n == 0)
            {
                int.TryParse(Console.ReadLine(), out n);
            }

            List<int> numbers = new List<int>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            for (int i = 0; i < 50; i++)
            {
                int number = queue.Dequeue();
                numbers.Add(number);
                queue.Enqueue(number + 1);
                queue.Enqueue(2 * number + 1);
                queue.Enqueue(number + 2);
            }
            PrintNumbers(numbers);
        }

        private static void PrintNumbers(List<int> numbers)
        {
            Console.WriteLine("Print numbers.");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

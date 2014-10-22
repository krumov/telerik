using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAllNegativeNums
{
    class RemoveAllNegativeNums
    {
        static void Main()
        {
            LinkedList<int> numbers = new LinkedList<int>();
            Console.WriteLine("Enter some numbers: ");

            bool isNumber = true;

            while (isNumber)
            {
                int number;
                isNumber = int.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    numbers.AddLast(number);
                }
            }

            var node = numbers.First;
            while (node != null)
            {
                var next = node.Next;
                if (node.Value < 0)
                    numbers.Remove(node);
                node = next;
            }

            Console.WriteLine(string.Join(" -> ", numbers));
        }
    }
}

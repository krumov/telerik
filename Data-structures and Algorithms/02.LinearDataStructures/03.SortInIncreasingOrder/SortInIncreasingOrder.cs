using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortInIncreasingOrder
{
    class SortInIncreasingOrder
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool isNumber = true;

            while (isNumber)
            {
                int number;
                isNumber = int.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    numbers.Add(number);
                }
            }

            var sortedNumbers = numbers.OrderBy(x => x);

            Console.WriteLine(string.Join(", ", sortedNumbers));
        }
    }
}

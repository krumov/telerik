using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrintDivisableBy7And3
{
    class PrintDivisableBy7And3
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1,2,3,4,5,12,13,14,16,18,20,21,34,42,57,84};

            var selectNumbers = numbers.Select(num => num % 7 == 0 && num % 3 == 0);// returns bool
           
            int count = 0;
            foreach (var num in selectNumbers)
            {
                if (num)
                {
                    Console.WriteLine(numbers[count]);
                }
                count++;
            }


            Console.WriteLine();
            Console.WriteLine("Method 2:");
            var selectNums2 = numbers.Where(num => num % 7 == 0 && num % 3 == 0);// another, probably easier method

            foreach (var num in selectNums2)
            {
                Console.WriteLine(num);
            }

            //with LINQ

            var selectWithLINQ =
                from num in numbers
                where num % 7 == 0 && num % 3 == 0
                select num;

            Console.WriteLine("\nWith LINQ query:\n");
            foreach (var num in selectWithLINQ)
            {
                Console.WriteLine(num);
            }

        }
    }
}

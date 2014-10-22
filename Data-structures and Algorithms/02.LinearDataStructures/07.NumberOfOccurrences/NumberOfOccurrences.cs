using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds in given array of integers (all belonging to the range [0..1000])
// how many times each of them occurs.


namespace NumberOfOccurrences
{
    class NumberOfOccurrences
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            Console.WriteLine("The original numbers:\n" + string.Join(", ", numbers) + "\n");

            Dictionary<int, int> occurences = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!occurences.ContainsKey(numbers[i]))
                {
                    occurences.Add(numbers[i], 1);
                }
                else
                {
                    occurences[numbers[i]]++;
                }
            }

            Console.WriteLine("The numbers occurances: ");

            var keys = occurences.Keys;

            foreach (var key in keys)
            {
                Console.WriteLine("{0} -> {1}", key, occurences[key]);
            }
                   
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountOccurencesInDoubleArray
{
    class CountOccurencesInDoubleArray
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>() { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            Console.WriteLine("The original numbers:\n" + string.Join(", ", numbers) + "\n");

            Dictionary<double, double> occurences = new Dictionary<double, double>();

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
                Console.WriteLine("{0} -> {1} times", key, occurences[key]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that removes from given sequence all numbers that occur odd number of times. 
// Example: {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}

namespace RemoveOddTimesOccurances
{
    class RemoveOddTimesOccurances
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            Console.WriteLine("The original numbers:\n" + string.Join(", ",numbers) + "\n");

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

            Console.WriteLine("The numbers that occur even times: ");

            var numsWithEvenOccurences = numbers.Where(num => occurences[num] % 2 == 0);

            Console.WriteLine(string.Join(", ",numsWithEvenOccurences) + "\n");
        }
    }
}

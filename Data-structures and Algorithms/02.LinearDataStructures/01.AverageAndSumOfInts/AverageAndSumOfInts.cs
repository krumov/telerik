using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads from the console a sequence of positive integer numbers.
// The sequence ends when empty line is entered. Calculate and print the sum and average of the elements of the sequence. 
// Keep the sequence in List<int>.


namespace AverageAndSumOfInts
{
    class AverageAndSumOfInts
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool isNumber = true;

            while (isNumber)
            {
                int number;                    
                isNumber = int.TryParse(Console.ReadLine(),out number);
                if (isNumber)
                {
                    numbers.Add(number);
                }                
            }

            var averageFromNumbers = numbers.Average();
            var sumOfNumbers = numbers.Sum();

            Console.WriteLine("The averige of the entered numbers is: " +  averageFromNumbers);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("The sum of the entered numbers is: " + sumOfNumbers);
            Console.WriteLine();

        }
    }
}

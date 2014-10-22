using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LoopRefactor
{
    class LoopRefactor
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random rand = new Random();
            // Generate random numbers to fill array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 40);
            }

            int expectedValue = 15;
            bool isFound = false;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        isFound = true;
                    }
                }
            }
            // More code here
            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}

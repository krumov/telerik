using System;

//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

class MaxSumInArray
{
    static void Main()
    {

        //read the array size
        Console.WriteLine("How big do you want the array to be?");
        Console.Write("N=");
        int sizeOfArrayN = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // read number K
        Console.WriteLine("How big do you want the array to be?");
        Console.Write("K=");
        int kElements = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //read array elements from the console
        int[] arrayOfIntegers = new int[sizeOfArrayN];
        for (int i = 0; i < sizeOfArrayN; i++)
        {
           arrayOfIntegers[i] = int.Parse(Console.ReadLine());
        }

        // calculating maximal sum of K elements
        int maxSum = 0;
        int maxSumCounter = 0;
        for (int i = 0; i <= sizeOfArrayN - kElements; i++)
        {
            int sum = 0;
            for (int j = 0; j < kElements; j++)
            {
                sum += arrayOfIntegers[i + j];
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                maxSumCounter = 1;
            }
            else if (sum == maxSum)
            {
                maxSumCounter++;
            }
        }

        // print result
        Console.WriteLine("Maximal sum is: {0}", maxSum);
        Console.WriteLine("Array have {0} maximal sum of {1} elements", maxSumCounter, kElements);
        Console.WriteLine("The sums are:");
        for (int i = 0; i <= sizeOfArrayN - kElements; i++)
        {
            int sum = 0;
            for (int j = 0; j < kElements; j++)
            {
                sum += arrayOfIntegers[i + j];
            }
            if (sum == maxSum)
            {
                for (int j = 0; j < kElements; j++)
                {
                    if (j < kElements - 1)
                    {
                        Console.Write("{0} + ", arrayOfIntegers[i + j]);
                    }
                    else
                    {
                        Console.WriteLine("{0} = {1}", arrayOfIntegers[i + j], maxSum);
                    }
                }
            }
        }
    }
}

using System;

//Write a program that finds the sequence of maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

class MaxSumInArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("How big do you want the array to be?");
        Console.Write("N=");
        int sizeOfArray = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] arrayOfInt = new int[sizeOfArray];

        Console.WriteLine("Enter the numbers of the array:");
        Console.WriteLine();

        for (int i = 0; i < sizeOfArray; i++)
        {
            arrayOfInt[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = arrayOfInt[0];
        int sum = arrayOfInt[0];
        int finalSequenceLength = 1;
        int currentSequenceLength = 1;
        int startIndex = 0;
        int startIndexTemp = 0;

        for (int i = 1; i < arrayOfInt.Length; i++)
        {
            if (arrayOfInt[i] + sum > arrayOfInt[i])
            {
                sum = arrayOfInt[i] + sum;
                currentSequenceLength++;
            }

            else
            {
                sum = arrayOfInt[i];
                startIndexTemp = i;
                currentSequenceLength = 1;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                finalSequenceLength = currentSequenceLength;
                startIndex = startIndexTemp;
            }
        }

        Console.WriteLine("---------------------------------------");

        for (int i = startIndex; i < startIndex + finalSequenceLength; i++)
        {
            Console.Write("{0} ", arrayOfInt[i]);
        }
        Console.WriteLine("\nMaximal sum is: {0}", maxSum);

    }
}

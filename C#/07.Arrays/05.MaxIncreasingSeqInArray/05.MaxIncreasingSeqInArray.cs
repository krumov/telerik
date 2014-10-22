using System;

//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

class MaxIncreasingSeqInArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("How big do you want the array to be?");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] arrayOne = new int[n];
        int maxCurSeq = 1;
        int maxSeq = 1;
        string num = "";

        Console.WriteLine("Enter the numbers in the array");

        for (int i = 0; i < n; i++)
        {
            arrayOne[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < n; i++)
        {
            if (arrayOne[i] == arrayOne[i - 1] + 1)
            {
                maxCurSeq++;
                if (maxCurSeq > maxSeq)
                {
                    num += arrayOne[i-1] + " ";
                }

            }
            else
            {
                if (maxCurSeq > maxSeq)
                {                    
                    maxSeq = maxCurSeq;
                    num += arrayOne[i - 1] + " ";
                }
                maxCurSeq = 1;
            }
        }

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("The maximal increasing sequence is: \n{0} ", num);
                   
    }
}

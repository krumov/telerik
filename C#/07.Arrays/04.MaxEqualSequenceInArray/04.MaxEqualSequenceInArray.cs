using System;

//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

class MaxEqualSequenceInArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("How big do you want the array to be?");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] arrayOne = new int[n];
        int maxCurSeq = 1;
        int maxSeq = 0;
        int num = 0;
        
        Console.WriteLine("Enter the numbers in the array");

        for (int i = 0; i < n; i++)
        {
            arrayOne[i] = int.Parse(Console.ReadLine());
        }
                
        for (int i = 1; i < n; i++)
        {
            if (arrayOne[i] == arrayOne[i - 1])
            {
                maxCurSeq++;
                if (maxCurSeq > maxSeq)
                {
                    num = arrayOne[i];
                }
               
            }
            else
            {
                if (maxCurSeq > maxSeq)
                {
                    maxSeq = maxCurSeq;
                }
                maxCurSeq = 1;
            }
        }

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("The maximal sequence of equal elements is: ");

        for (int i = 0; i < maxSeq; i++)
        {
            Console.Write(num + " ");            
        }

        Console.WriteLine();
    }
    
}

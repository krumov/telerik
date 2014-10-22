using System;

//Write a program that reads two arrays from the console and compares them element by element.

class CompareTwoArrays
{
    static void Main(string[] args)
    {
        Console.WriteLine("How big do you want the arrays to be?");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] arrayOne = new int[n];
        int[] arrayTwo = new int[n];

        Console.WriteLine("Enter the numbers of the first array");

        for (int i = 0; i < n; i++)
			{
			    arrayOne[i] = int.Parse(Console.ReadLine());
			}

        Console.WriteLine("Enter the numbers of the second array");

        for (int i = 0; i < n; i++)
		    {
			    arrayTwo[i] = int.Parse(Console.ReadLine());
		    }

        bool areEqual = true;

        for (int i = 0; i < n; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                    areEqual = true;
                else
                {
                    areEqual = false;
                    break;
                }
            }

        if (areEqual)
            Console.WriteLine("The arrays are equal");
        else
            Console.WriteLine("The arrays are NOT equal");
    }
}

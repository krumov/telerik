using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

class CompareTwoCharArrays
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many letters do you want your array to have?");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        string[] arrayOne = new string[n];
        string[] arrayTwo = new string[n];

        Console.WriteLine("Enter the letters of the first array");

        for (int i = 0; i < n; i++)
        {
            arrayOne[i] = Console.ReadLine();
        }

        Console.WriteLine("Enter the letters of the second array");

        for (int i = 0; i < n; i++)
        {
            arrayTwo[i] = Console.ReadLine();
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

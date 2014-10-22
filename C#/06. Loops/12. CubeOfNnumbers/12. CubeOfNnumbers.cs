using System;

class CubeOfNnumbers

//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:

{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            for (int j = 1 + i; j <= n + i; j++)
            {
                Console.Write(j);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}


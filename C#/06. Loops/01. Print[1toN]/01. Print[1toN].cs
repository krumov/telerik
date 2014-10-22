using System;

class Print1toN
//Write a program that prints all the numbers from 1 to N.
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number n= ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}


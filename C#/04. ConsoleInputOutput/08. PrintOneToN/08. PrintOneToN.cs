﻿using System;

class PrintOneToN
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a number");
        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

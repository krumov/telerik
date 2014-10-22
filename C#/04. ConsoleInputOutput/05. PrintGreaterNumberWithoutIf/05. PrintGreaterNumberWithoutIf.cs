using System;

class PrintGreaterNumberWithoutIf
//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
    
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write first positive number:");
        int numberA = int.Parse(Console.ReadLine());
        Console.WriteLine("Write the second positive number");
        int numberB = int.Parse(Console.ReadLine());
        Console.WriteLine("The greater of the two numbers is {0}",Math.Max(numberA,numberB));        
    }
}

using System;

class CompareFloat
{
    static void Main(string[] args)
    // A program that compares 2 numbers with a precision of 0.000001
    // I found out that for the program to work you have to use "," and not a "."

    {
        Console.WriteLine("Enetr first nuber");
        float firstNum = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter second nuber");
        float secondNum = float.Parse(Console.ReadLine());

        bool areEqual = firstNum == secondNum;
        Console.WriteLine("Are the numbers equal = " + areEqual);
    }
}

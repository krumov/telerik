using System;

class ReadThreeNumbersAndPrint
//Write a program that reads 3 integer numbers from the console and prints their sum.

{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the first number");
        double numberOne = double.Parse(Console.ReadLine());
        Console.WriteLine("Write the second number");
        double numberTwo = double.Parse(Console.ReadLine());
        Console.WriteLine("Write the third number");
        double numberThree = double.Parse(Console.ReadLine());

        double sum = (double)numberOne + (double)numberTwo + (double)numberThree;

        Console.WriteLine("The sum of the three numbers is {0}", sum);

        //I used double so that you can also enter numbers with a floating point
    }
}


using System;

class BiggestOfThree
{
    //Write a program that finds the biggest of three integers using nested if statements.

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter a second number: ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter a third number: ");
        int numberThree = int.Parse(Console.ReadLine());

        if ((numberOne >= numberTwo && numberOne >= numberThree))
        {
            Console.WriteLine("{0} is the biggest number.", numberOne);
        }
        else if (numberTwo >= numberOne && numberTwo >= numberThree)
        {
            Console.WriteLine("{0} is the biggest number.", numberTwo);
        }
        else
        {
            Console.WriteLine("{0} is the biggest number.", numberThree);
        }


    }
}
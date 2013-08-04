using System;

class IsGreaterThenExchange
{
    //Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter a second number: ");
        int numberTwo = int.Parse(Console.ReadLine());

        if (numberOne > numberTwo)
        {
            numberOne = numberTwo;
            Console.WriteLine("The value of the first number was exchanged with the value of the second number and is now: {0}", numberOne);
        }
        else
        { 
            Console.WriteLine("The numbers remain the same, the first number is {0}", numberOne);
        }
    }
}

using System;

class SortInDescendingOrder
{
    //Sort 3 real values in descending order using nested if statements.
    
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double numberOne = double.Parse(Console.ReadLine());
        Console.Write("Enter a second number: ");
        double numberTwo = double.Parse(Console.ReadLine());
        Console.Write("Enter a third number: ");
        double numberThree = double.Parse(Console.ReadLine());

        if (numberOne > numberTwo && numberOne > numberThree)
        {
            if (numberTwo>numberThree)
            {
                Console.WriteLine(numberOne);
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberThree);
            }
            else
            {
                Console.WriteLine(numberOne);
                Console.WriteLine(numberThree);
                Console.WriteLine(numberTwo);
            }
        }
        else if (numberTwo > numberOne && numberTwo > numberThree)
        {
            if (numberOne > numberThree)
            {
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberOne);
                Console.WriteLine(numberThree);
            }
            else
            {
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberThree);
                Console.WriteLine(numberOne);
            }
        }
        else if (numberThree > numberOne && numberThree > numberTwo)
        {
            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberThree);
                Console.WriteLine(numberOne);
                Console.WriteLine(numberTwo);
            }
            else
            {
                Console.WriteLine(numberThree);
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberOne);
            }
        }

    }
}


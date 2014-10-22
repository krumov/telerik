using System;

class SignOfTheProductOfThreeNumbers
{
    //Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

    static void Main(string[] args)
    {
        Console.Write("Enter a real number: ");
        double numberOne = double.Parse(Console.ReadLine());
        Console.Write("Enter a second number with a different sign: ");
        double numberTwo = double.Parse(Console.ReadLine());
        Console.Write("Enter a third number (with wathever sign you want): ");
        double numberThree = double.Parse(Console.ReadLine());

        if (numberOne == 0 || numberTwo == 0 || numberThree == 0)
        {
            Console.WriteLine("The product of the three numbres will be 0");
        }
        else
        {
            if (numberOne < 0 ^ numberTwo < 0 ^ numberThree < 0)
            {
                Console.WriteLine("The sign of the product of the three numbers is -");
            }
            else
            {
                Console.WriteLine("The sign of the product of the three numbers is +");
            }
        }
        
    }
}

using System;

class IsIntOddOrEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a number: ");
        int isOdd = int.Parse(Console.ReadLine());

        if (isOdd % 2 == 0)
        {
            Console.WriteLine("The number you wrote is even");
        }
        else
        {
            Console.WriteLine("The number you wrote is odd");
        }
    }
}

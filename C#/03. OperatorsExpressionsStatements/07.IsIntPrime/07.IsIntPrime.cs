using System;

class IsIntPrime
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a positive integer to find out if it's a prime number: ");
        uint number = uint.Parse(Console.ReadLine());

        bool isPrime = true;
        for (int i = 2; i < Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine("{0} {1} a prime number", number, isPrime ? "is" : "is not");
    }
}


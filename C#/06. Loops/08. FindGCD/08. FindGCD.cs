using System;

class FindGCD
    // Find the gratest common divisor of two given numbers
{
    static void Main(string[] args)
    {
        Console.Write("Wrie a number n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Wrie a number k = ");
        int k = int.Parse(Console.ReadLine());
        int remainder = 1;

        while (remainder != 0)
        {
            remainder = n % k;
            n = k;
            k = remainder;
        }
        Console.WriteLine();
        Console.WriteLine("The greatest common divisor is {0}", n);
        
    }
}


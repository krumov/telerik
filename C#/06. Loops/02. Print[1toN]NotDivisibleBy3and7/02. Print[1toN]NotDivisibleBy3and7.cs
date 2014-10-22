using System;

class Print1toNnotDivisibleBy3and7
    //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number n= ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 7 ==0) // if the number is divisible by 3 and 7 without a reminder it will be skipped. 
                                            //The first skipped number will be 21 (the smallest number divisible by 3 and 7)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}


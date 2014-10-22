using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
// If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
// a1, a2, … a10, such that 1 < a1 < … < a10 < 100

class ReadNumInRangeMethod
{
    static int ReadNumber(int start, int end)
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num < start || num > end)
            {
                throw new IndexOutOfRangeException("The number is not in the range you specified");
            }
            return num;
        }
        catch (OverflowException)
        {
            throw new OverflowException("Your number is too big");
        }
        catch (FormatException)
        {
            throw new FormatException("You did not enter a number in the required format");
        }

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers for start and end such that - 1 <= start < end <= 100");
        Console.Write("Start: ");
        int start = int.Parse(Console.ReadLine());
        if (start < 1)
        {
            throw new FormatException("The number is not in the range 1 - 100");
        }
        Console.Write("End: ");
        int end = int.Parse(Console.ReadLine());
        if (end > 100)
        {
            throw new FormatException("The number is not in the range 1 - 100");
        }

        int[] numbers = new int[10];

        Console.WriteLine("Enter 10 numbers: ");

        for (int i = 0; i < 10; i++)
        {
            numbers[i] = ReadNumber(start, end);
        }
       
    }
}


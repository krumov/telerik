using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that reverses the digits of given decimal number. Example: 256  652

class ReverseDigits
{
    static int DigitsReversed(int num)
    {

        int reversed = 0;
        while (num > 0)
        {
            reversed = reversed * 10 + num % 10;
            num = num / 10;
        }
        return reversed;

    }
    
    static void Main(string[] args)
    {
        Console.Write("Write a number to be reversed:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe reversed number: " + DigitsReversed(num) + "\n");
    }
}


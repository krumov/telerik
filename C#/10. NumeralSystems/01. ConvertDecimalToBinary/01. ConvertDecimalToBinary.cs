using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program to convert decimal numbers to their binary representation.

class ConvertDecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Write a decimal number to convert to binary: ");
        int num = int.Parse(Console.ReadLine());
        int remainder;

        List<int> binaryNumber = new List<int>();

        do
        {
            remainder = num % 2;
            binaryNumber.Add(remainder);
            num = num / 2;
        } while (num != 0);

        binaryNumber.Reverse();

        Console.Write("\nThe binary representation of the number you entered is: ");
        for (int i = 0; i < binaryNumber.Count; i++)
        {
            Console.Write("{0} ", binaryNumber[i]);
        }
        Console.WriteLine("\n");
    }
}


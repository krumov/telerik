using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their hexadecimal representation.

class ConvertDecimalToHex
{
    static void Main(string[] args)
    {
        Console.Write("Write a decimal number to convert to hex: ");
        int num = int.Parse(Console.ReadLine());
        int remainder;
        
        List<int> hexNumber = new List<int>();

        do
        {
            remainder = num % 16;
            hexNumber.Add(remainder);
            num = num / 16;
        } while (num != 0);

        hexNumber.Reverse();

        Console.Write("\nThe hex representation of the number you entered is: ");
        for (int i = 0; i < hexNumber.Count; i++)
        {
            if (hexNumber[i] > 9)
            {
                Console.Write("{0} ", (char)(hexNumber[i]+55)); // you look at the ASCII table you will see that from 65 -> the symbols are "A,B,C...."
            }
            else
            Console.Write("{0} ", hexNumber[i]);
        }
        Console.WriteLine("\n");
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to their decimal representation.

class ConvertHexToDecimal
{
    private static int Pow(int sqr)
    {
        return (1 << (sqr * 4));
    }

    static void Main()
    {
        Console.WriteLine("Please enter hexadecimal number without 0x...");
        string hexaNumber = Console.ReadLine();
        int count = hexaNumber.Length - 1;
        int digit = 0;
        int result = 0;

        for (int i = 0; i < hexaNumber.Length; i++)
        {
            switch (hexaNumber[i])
            {
                case 'A':
                case 'a':
                    digit = 10; break;
                case 'B':
                case 'b':
                    digit = 11; break;
                case 'C':
                case 'c':
                    digit = 12; break;
                case 'D':
                case 'd':
                    digit = 13; break;
                case 'E':
                case 'e':
                    digit = 14; break;
                case 'F':
                case 'f':
                    digit = 15; break;
                default: digit = int.Parse(Convert.ToString(hexaNumber[i])); break;
            }

            result += digit * Pow(count);
            count--;
        }

        Console.WriteLine(result);
    }
}


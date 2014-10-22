using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads from the console a string of maximum 20 characters. 
// If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.

class Read20Chars
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter string with no more than 20 characters!");
        string text = Console.ReadLine();
        int maxLength = 20;
        Console.WriteLine();

        if (text.Length > maxLength)
        {
            Console.WriteLine("ERROR! LOADING BLUE SCREEN OF DEATH!");
        }
        else
        {
            Console.WriteLine(text.PadRight(maxLength, '*'));
            Console.WriteLine();
        }
    }
}

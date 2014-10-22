using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample"  "elpmas".

class ReverseString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();
        char[] strArr = str.ToCharArray();

        Array.Reverse(strArr);

        Console.WriteLine("The reversed string: ");
        Console.WriteLine(strArr);
        Console.WriteLine();
    }
}


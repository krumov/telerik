using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

class ConvertToCsharpUnicode
{
    static void Main()
    {
        string str = "Hi!";
        StringBuilder utf = new StringBuilder(str.Length * 6);

        foreach (char c in str)
            utf.AppendFormat("\\u{0:X4}", (int)c);

        string result = utf.ToString();

        Console.WriteLine(result);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested.
// Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
// The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

class ToUppercase
{
    static void Main(string[] args)
    {
        string str = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        int startIndex = 0;
        int endIndex = 0;
        Console.WriteLine(str);
        Console.WriteLine();

        for (int i = 0; i < str.Length - 8; i++)
        {
            if (str.Substring(i, 8) == "<upcase>")
            {
                startIndex = i + 8;
                i = startIndex;
            }
            if (str.Substring(i, 9) == "</upcase>")
            {
                endIndex = i;
                int length = endIndex - startIndex;
                string upperStr = str.Substring(startIndex, length).ToUpper();
                
                str = str.Remove(startIndex, length);
               
                str = str.Insert(startIndex, upperStr);
               
                str = str.Remove(startIndex - 8, 8);
                str = str.Remove(endIndex - 8, 9);
            }
        }
        Console.WriteLine(str);
        Console.WriteLine();
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that replaces all occurrences of the substring "start" with the 
// substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

class ChangeGivenSubstring
{
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = line.Replace("start", "finish");
                    writer.WriteLine(newLine);
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

class PrintOddLinesOfFile
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(@"..\..\test.txt");
        using (reader)
        {
            string currLine = reader.ReadLine();
            int counter = 1;
            while (currLine != null)
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine(currLine);
                }
                currLine = reader.ReadLine();
                counter++;
            }
        }
    }
}


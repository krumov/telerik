using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a text file containing a list of strings, 
// sorts them and saves them to another text file. Example:

class SortTextFile
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(@"..\..\input.txt");

        List<string> inputData = new List<string>();

        using (reader)
        {
            string currLine;
            while ((currLine = reader.ReadLine()) != null)
            {
                inputData.Add(currLine);
            }

            inputData.Sort();
        }

        StreamWriter writer = new StreamWriter(@"..\..\output.txt");

        using (writer)
        {
            for (int i = 0; i < inputData.Count; i++)
            {
                writer.WriteLine(inputData[i]);
            }
        }
    }
}


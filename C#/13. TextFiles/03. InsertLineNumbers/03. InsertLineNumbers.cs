using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

class InsertLineNumbers
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(@"..\..\03. InsertLineNumbers.cs");
        StreamWriter writer = new StreamWriter(@"..\..\output.txt");

        using (writer)
        {
            using (reader)
            {
                int counter = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    writer.WriteLine("{0}: {1}", counter, line);
                    counter++;
                }
            }
        }
    }
}


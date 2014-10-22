using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Modify the solution of the previous problem to replace only whole words (not substrings).

class ChangeGivenWordInFile
{
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                string pattern = @"\b(start)\b";
                Regex rgx = new Regex(pattern);

                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = rgx.Replace(line, "finish");
                    writer.WriteLine(newLine);
                }
            }
        }
    }
}


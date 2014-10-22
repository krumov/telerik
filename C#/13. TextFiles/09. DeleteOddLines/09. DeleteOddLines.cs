using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that deletes from given text file all odd lines. The result should be in the same file.

class DeleteOddLines
{
     //static List<string> ReadEvenLines()
     //   {
     //       List<string> lines = new List<string>();

     //       int n = 1;

     //       using (StreamReader input = new StreamReader("../../test.txt"))
     //           for (string line; (line = input.ReadLine()) != null; n++)
     //               if (n % 2 == 0) lines.Add(line);

     //       return lines;
     //   }

     //   static void WriteLines(List<string> lines)
     //   {
     //       using (StreamWriter output = new StreamWriter("../../test.txt"))
     //           foreach (string line in lines)
     //               output.WriteLine(line);
     //   }

        static void Main()
        {
            //WriteLines(ReadEvenLines());

            List<int> testArr = new List<int>{ 1, 2, 4, 6, 7, 9 };

            for (int i = 0; i < testArr.Count; i++)
            {
                Console.WriteLine(testArr[i]);
            }

            testArr.Insert(1, 3);
            Console.WriteLine();
            for (int i = 0; i < testArr.Count; i++)
            {
                Console.WriteLine(testArr[i]);
            }

        }
    
}


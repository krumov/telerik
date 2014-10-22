using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that compares two text files line by line and prints the number of lines 
//that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

class CompareTwoFiles
{
    static void Main(string[] args)
    {
        StreamReader fileOne = new StreamReader("fileOne.txt");
        StreamReader fileTwo = new StreamReader("fileTwo.txt");
        int countSame = 0;
        int countDiff = 0;
       
        using (fileOne)
        {
            using (fileTwo)
            {
                
                string fileOneData, fileTwoData;
                string currLine;
                while ((currLine = fileOne.ReadLine()) != null)
                {
                    fileOneData = currLine;
                    fileTwoData = fileTwo.ReadLine();

                    if (fileOneData == fileTwoData)
                    {
                        countSame++;
                    }
                    else
                    {
                        countDiff++;
                    }
                }
             }
        }

        Console.WriteLine("The two files have {0} lines that are different\nand {1} lines that are the same", countDiff, countSame);
    }
}


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that concatenates two text files into another text file.

class ConcatenateTwoTextFiles
{
    static void Main(string[] args)
    {
        StreamReader fileOne = new StreamReader("fileOne.txt");
        StreamReader fileTwo = new StreamReader("fileTwo.txt");
        StreamWriter newFile = new StreamWriter("newFile.txt");

        using (newFile)
        {
            using (fileTwo)
            {
                using (fileOne)
                {
                    string fileOneData = fileOne.ReadToEnd();
        
                    string fileTwoData = fileTwo.ReadToEnd();

                    string newData = fileOneData + "\n" + fileTwoData;
        
                     newFile.WriteLine(newData);
                   
                }
            }
        }
    }
}


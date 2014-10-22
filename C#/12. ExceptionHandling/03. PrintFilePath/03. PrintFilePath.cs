using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Wr have to use this or it will not work.

// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
// reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
// Be sure to catch all possible exceptions and print user-friendly error messages.

class PrintFilePath
{
    static void Main()
    {
        Console.WriteLine("Enter the full path of the file you want to read: ");
        string filePath = Console.ReadLine();
        ReadFile(filePath);
    }

    static void ReadFile(string filePath)
    {
        try
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("The content of the file is:\n{0}",fileContent);
        }

        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The file path contains a directory that cannot be found!");
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("The file '{0}' was not found!", filePath);
        }

        catch (ArgumentNullException)
        {
            Console.WriteLine("No file path is given!");
        }

        catch (ArgumentException)
        {
            Console.WriteLine("The entered file path is not correct!");
        }

        catch (PathTooLongException)
        {
            Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
        }

        catch (UnauthorizedAccessException uoae)
        {
            Console.WriteLine(uoae.Message);
        }
       
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file path format!");
        }

        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}


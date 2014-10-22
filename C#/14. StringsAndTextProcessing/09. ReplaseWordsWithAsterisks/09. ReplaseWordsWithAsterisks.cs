using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// We are given a string containing a list of forbidden words and a text containing some of these words. 
// Write a program that replaces the forbidden words with asterisks

class ReplaseWordsWithAsterisks
{
    static void Main(string[] args)
    {
        string textInput = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        //string textInput = Console.ReadLine();
        string[] forbidenWords = "PHP, CLR, Microsoft".Split(',');
        for (int i = 0; i < forbidenWords.Length; i++)
        {
            forbidenWords[i] = forbidenWords[i].Trim();
            textInput = textInput.Replace(forbidenWords[i], new string('*', forbidenWords[i].Length));
        }

        Console.WriteLine(textInput);
    }
}

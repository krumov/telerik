using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

class MethodForInputingUserName
{
    static void PrintName(string name)
    {
        Console.WriteLine("\nHello, {0}\n", name); 
    }

    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        Console.Write("Name: ");
        string userName = Console.ReadLine();

        PrintName(userName);
    }
}


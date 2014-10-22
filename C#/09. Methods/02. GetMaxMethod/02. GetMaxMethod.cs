using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints 
//the biggest of them using the method GetMax().

class GetMaxMethod
{
    static int GetMax(int numOne, int numTwo)
    {
        return Math.Max(numOne, numTwo);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers: ");

        int numOne, numTwo, numThree;

        numOne = int.Parse(Console.ReadLine());
        numTwo = int.Parse(Console.ReadLine());
        numThree = int.Parse(Console.ReadLine());

        int biggest = GetMax(GetMax(numOne, numTwo), numThree);

        Console.WriteLine("The biggest of the three numbers is {0}", biggest);
    }
}


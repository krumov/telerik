using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

class CalcNfactorialFor1to100
{
    static BigInteger Factorial(int num)
    {
        BigInteger numFactorial = 1;
        int counter = num;
        for (int i = 0; i < counter; i++)
        {
            numFactorial = numFactorial * num;
            num--;
        }
        return numFactorial;
    }

    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(Factorial(i + 1));
        }
    }
}


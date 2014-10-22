using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

class RandomValuesInRange
{
    static void Main(string[] args)
    {
        Random randomNums = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomNums.Next(100,200));
        }
        
    }
}


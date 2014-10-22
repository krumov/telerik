using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class IsLeapYear
{
    static void Main(string[] args)
    {
        Console.Write("Write a year to find out if it is a leap year:\n\nYear: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("\n{0} IS a leap year\n", year);
        }
        else
        {
            Console.WriteLine("\n{0} IS NOT leap year\n", year); ;
        }
    }
}


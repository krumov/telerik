using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints to the console which day of the week is today. Use System.DateTime.

class PrintDayOfWeek
{
    static void Main(string[] args)
    {
        DateTime time = DateTime.Now;              // Use current time

	    string format = "ddddddddd";              // Use this format (write just the day with up to 7 letters) 
                                                       //the day should be printed in whatever language your computer is set to.

	    Console.WriteLine("Today is {0}", time.ToString(format));
       
    }
}


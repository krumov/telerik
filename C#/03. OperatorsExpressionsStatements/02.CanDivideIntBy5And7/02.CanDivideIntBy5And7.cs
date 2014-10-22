using System;

class CanDivideIntBy5And7
{
    static void Main(string[] args)
    {
        // The tast is to to check with a bool if the entered number can be dividet by 5 and 7 at the same time
        Console.WriteLine("Write a number: ");
        int Number = int.Parse(Console.ReadLine());


        if (Number % 5 == 0)
        {
            if (Number % 7 == 0)
            {
                bool isDividableBy7And5 = true;
                Console.WriteLine("The number you wrote is dividable by 7 and 5, without a remainder = {0}", isDividableBy7And5);
            }

            else
            {
                bool isDividableBy7And5 = false;
                Console.WriteLine("The number you wrote is dividable by 7 and 5, without a remainder = {0}", isDividableBy7And5);
            }
        }
        else
        {
            bool isDividableBy7And5 = false;
            Console.WriteLine("The number you wrote is dividable by 7 and 5, without a remainder = {0}", isDividableBy7And5);
        }
    }
}

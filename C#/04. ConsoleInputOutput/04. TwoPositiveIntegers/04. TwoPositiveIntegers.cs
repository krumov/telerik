using System;

class TwoPositiveIntegers
    //Write a program that reads two positive integer numbers and prints how many numbers p exist 
    //between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.


{
    static void Main(string[] args)
    {
        Console.WriteLine("Write first positive number:");
        int numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Write the second positive number");
        int numberTwo = int.Parse(Console.ReadLine());

        int answer = 0;
        int i;
        for (i = numberOne; i <= numberTwo; i++)
            if (i % 5 == 0)
            {
            answer = answer + 1;
            }
            
       Console.WriteLine("There are {0} numbers between the two you wrote that have a reminder of 0 when they are devided by 5", answer);
    }
}

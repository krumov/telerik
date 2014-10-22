using System;

class CheckThirdDigit
{
    static void Main()

        //Is the third digit (right to left) of a number = 7

    {
        Console.WriteLine("Write a number with atleast 3 digits: ");
        int number = int.Parse(Console.ReadLine());

        int thirdDigit = (number / 100) % 10; 
        if (thirdDigit == 7)
        {
            Console.WriteLine("The third digit is 7!");
        }
        else
        {
            Console.WriteLine("The third digit is not 7");
        }
    }
}
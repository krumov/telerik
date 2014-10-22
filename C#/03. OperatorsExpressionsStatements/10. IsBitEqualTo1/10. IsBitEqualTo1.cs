using System;

class IsBitEqualTo1
{
    static void Main(string[] args)

        //Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 false.

    {
        Console.WriteLine("Write a number: ");
        int numberV = int.Parse(Console.ReadLine());
        Console.WriteLine("Write a bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());
        

        int mask = 1 << bitPosition;

        int numberAndMask = numberV & mask;

        int bit = numberAndMask >> bitPosition;

        if (bit == 1)
        {
            Console.WriteLine("The bit in the position you entered is 1");
        }
        else
        {
            Console.WriteLine("The bit in the position you entered is 0");
        }
    }
}

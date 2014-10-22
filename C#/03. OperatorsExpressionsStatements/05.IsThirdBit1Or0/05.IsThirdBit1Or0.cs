using System;

class IsThirdBit1Or0
{
    static void Main(string[] args)

        //Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

    {
        Console.WriteLine("Write a number: ");
        int number = int.Parse(Console.ReadLine());
        int bitPosition = 3;

        int mask = 1 << bitPosition;

        int numberAndMask = number & mask;

        int bit = numberAndMask >> bitPosition;

        if (bit == 0)
            {
                Console.WriteLine("Third bit is 0");
            }
            else
            {
                Console.WriteLine("Third bit is 1");
            }
    }
}

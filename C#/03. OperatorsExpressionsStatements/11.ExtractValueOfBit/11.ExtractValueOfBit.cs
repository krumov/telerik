using System;

class ExtractValueOfBit
{
    static void Main(string[] args)

        //Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

    {
        Console.WriteLine("Write a number: ");
        int numberV = int.Parse(Console.ReadLine());
        Console.WriteLine("Write a bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());


        int mask = 1 << bitPosition;

        int numberAndMask = numberV & mask;

        int bit = numberAndMask >> bitPosition;

        Console.WriteLine("The bit in the position you entered is {0}",bit);
       
    }
}
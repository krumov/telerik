using System;

class PrintASCIITable
{
    static void Main(string[] args)
    {

        for (int symbol = 32; symbol < 128; symbol++) //I found that the most common ASCII sybols in decimal form are from 32 to 127
        {
            Console.WriteLine((char)symbol);
        }
    }
}


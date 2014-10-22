using System;

class CharVariable
{
    static void Main(string[] args)
    {
        // Declare a character variable and assign it with the symbol that has Unicode code 72
        //The Hex equivalent of 72 is 48, 

        char charVariable = '\u0048';
        //char charVariable = (char)0x48; - a different way to do it
        Console.WriteLine(charVariable);
    }
}

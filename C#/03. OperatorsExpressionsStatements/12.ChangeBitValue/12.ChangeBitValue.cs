using System;

class ChangeBitValue
{
    static void Main(string[] args)
    
        //We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n 
        //to hold the value v at the position p from the binary representation of n.
	    //Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	    //n = 5 (00000101), p=2, v=0  1 (00000001)

    {

        Console.WriteLine("Write a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Write a bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Write a bit value (1 or 0): ");
        int bitValue = int.Parse(Console.ReadLine());

        int mask = 1 << bitPosition;

        if (bitValue == 0)
        {
            number = number & (~mask);
            Console.WriteLine("Number's new value is: {0}", number);            
        }
        else 
        {
            number = number | mask;
            Console.WriteLine("Number's new value is: {0}", number);            
        }

    }
}
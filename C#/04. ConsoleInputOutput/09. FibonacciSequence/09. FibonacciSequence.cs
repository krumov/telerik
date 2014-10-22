using System;

class FibonacciSequence
//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

{
    static void Main(string[] args)
    {
        decimal a = 0;
        decimal b = 1M;
        decimal c = 0;
       
        int i;

       
        for (i = 0; i <= 100; i++)
        {
            Console.WriteLine(c);
            c = a + b;
            a = b;
            b = c; 
        }
    }
}

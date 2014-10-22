using System;

class SumOfNmembersOfFibonacci
    /*Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 
     * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
     * Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
     */
{
    static void Main(string[] args)
    {
        Console.Write("Write how many numbers of the fibonacci sequence you want to sum: ");
        ulong N = ulong.Parse(Console.ReadLine());

        ulong a = 1;
        ulong b = 0;
        ulong c = 0;
        ulong sum = 0;

        for (ulong i = 0; i < N; i++)
        {
            c = a + b;
            a = b;
            b = c;
            sum = sum + c;
        }
        
        Console.WriteLine();
        Console.WriteLine("The sum of the first {0} numbers of the sequence of Fibonacci is: {1}",N,sum);
    }
}


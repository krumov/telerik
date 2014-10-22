using System;

class CalculateFactorialExpression
//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
{
    static void Main(string[] args)
    {
        Console.Write("Wrie a number k = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Wrie a number n, lower than k and bigger than 1,  n= ");
        int n = int.Parse(Console.ReadLine());

        int sum = k -n;
        decimal Nfactorial = 1;
        decimal Kfactorial = 1;
        decimal SumFactorial = 1;
        
        do
        {
            Nfactorial = Nfactorial * n;
            n--;
        }
        while (n > 0);

        do
        {
            Kfactorial = Kfactorial * k;
            k--;
        }
        while (k > 0);

         do
        {
            SumFactorial = SumFactorial * sum;
            sum--;
        }
        while (sum > 0);

        decimal result = (Nfactorial * Kfactorial)/ SumFactorial;

        Console.WriteLine("The result of N!*K! / (K-N)! is: {0} ", result);
    }
}
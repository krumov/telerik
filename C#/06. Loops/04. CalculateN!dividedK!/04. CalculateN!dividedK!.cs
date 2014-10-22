using System;

class CalculateNfakDividedKfak
//Write a program that calculates N!/K! for given N and K (1<K<N).
{
    static void Main(string[] args)
    {
        Console.Write("Wrie a number n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Wrie a number k, lower than n and bigger than 1,  k= ");
        int k = int.Parse(Console.ReadLine());

        decimal Nfactorial = 1;
        decimal Kfactorial = 1;
        
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

        decimal result = Nfactorial / Kfactorial;
        Console.WriteLine("The result of N!/K! is: {0} " ,result);
    }
}
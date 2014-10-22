using System;

class NthCatalanNumber
//Write a program to calculate the Nth Catalan number by given N.
{
    static void Main(string[] args)
    {
        Console.Write("Wrie which catalan number you would like to see,  n = ");
        int n = int.Parse(Console.ReadLine());

        decimal Nfactorial = 1;
        decimal Nplus1Factorial = 1;
        decimal TwoNfactorial = 1;

        int Nplus1 = n + 1;
        int TwoN = 2 * n;

        do
        {
            Nfactorial = Nfactorial * n;
            n--;
        }
        while (n > 0);

        do
        {
            Nplus1Factorial = Nplus1Factorial * Nplus1;
            Nplus1--;
        }
        while (Nplus1 > 0);

        do
        {
            TwoNfactorial = TwoNfactorial * TwoN;
            TwoN--;
        }
        while (TwoN > 0);

        decimal NthCatalanNum = TwoNfactorial / (Nplus1Factorial * Nfactorial);

        Console.WriteLine("The catalan number is {1}", NthCatalanNum);
    }
}


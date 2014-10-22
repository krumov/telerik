using System;

class CalcSumOfNandX
//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number N= ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter a number X= ");
        int numberX = int.Parse(Console.ReadLine());

        decimal Nfactorial = 1;
        decimal totalSum = 1;
        double power = 1;
        double powered = 1;
                
        for (decimal i = 1; i <= numberN; i++)
        {
            Nfactorial = Nfactorial * i;
            powered = Math.Pow(numberX, power);
            decimal poweredTodecimal = Convert.ToDecimal(powered);
                    
            totalSum = totalSum + (Nfactorial / poweredTodecimal);
            power++;
        }
        Console.WriteLine("The result is: {0} ", totalSum);
      }
}


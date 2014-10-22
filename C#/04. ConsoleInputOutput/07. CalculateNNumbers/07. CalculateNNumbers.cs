using System;

class CalculateNNumbers
//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

{
    static void Main(string[] args)
    {
        Console.WriteLine("Input how many numbers you would like to sum");
        Console.Write("n = ");
        int Number = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int counter = 0; counter < Number; counter++)
        {
            Console.WriteLine("Input number for summing");
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            sum = sum + x;
        }
        Console.WriteLine("The sum of the numbers is: {0}" ,sum);
    }
}

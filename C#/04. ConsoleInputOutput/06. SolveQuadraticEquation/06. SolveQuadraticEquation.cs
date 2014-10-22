using System;

class SolveQuadraticEquation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

{
    static void Main(string[] args)
    {
        Console.WriteLine("Write first (a) coeficient of a quadratic equation:");
        double coefficientA = double.Parse(Console.ReadLine());
        Console.WriteLine("Write second (b) coeficient of a quadratic equation");
        double coefficientB = double.Parse(Console.ReadLine());
        Console.WriteLine("Write third (c) coeficient of a quadratic equation:");
        double coefficientC = double.Parse(Console.ReadLine());
        
        double rootX;
        double rootX1;
        double rootX2;

        double discriminant = (Math.Pow(coefficientB,2)) - (4 * coefficientA * coefficientC);

        if (discriminant < 0)
            {
                Console.WriteLine("The equation has no real roots");
            }
        else if (discriminant == 0)
            {
                rootX = -coefficientB / (2 * coefficientA);
                Console.WriteLine("The equation has only one root: {0}", rootX);
            }
        else
            {
                rootX1 = (-coefficientB + Math.Sqrt(discriminant) / 2 * coefficientA);
                rootX2 = (-coefficientB - Math.Sqrt(discriminant) / 2 * coefficientA);
                Console.WriteLine("The equation has two real roots: {0} and {1}", rootX1, rootX2);
            }
    }
}

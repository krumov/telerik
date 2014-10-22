using System;

class QuadraticEcuation
{
    /*  Write a program that enters the coefficients a, b and c of a quadratic equation
	    a*x2 + b*x + c = 0 and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Write first (a) coeficient of the quadratic equation - a*x2 + b*x + c :");
        double coefficientA = double.Parse(Console.ReadLine());
        Console.WriteLine("Write second (b) coeficient of the quadratic equation - a*x2 + b*x + c :");
        double coefficientB = double.Parse(Console.ReadLine());
        Console.WriteLine("Write third (c) coeficient of the quadratic equation - a*x2 + b*x + c :");
        double coefficientC = double.Parse(Console.ReadLine());

        double rootX;
        double rootX1;
        double rootX2;

        double discriminant = (Math.Pow(coefficientB, 2)) - (4 * coefficientA * coefficientC);

        if (coefficientA == 0)
        {
            Console.WriteLine("If coefficient a is 0 - this is not e quadratic ecuation");
        }
        else
        {
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
}

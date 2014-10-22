using System;

class CalcTrapezoidArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the trapezoid side A: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.WriteLine("Write the trapezoid side B: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.WriteLine("Write the trapezoid Height: ");
        double Height = double.Parse(Console.ReadLine());

        double TrapezoidArea = Height * ((sideA+sideB)/2);

        Console.WriteLine("The trapezoids' area is 1/2 times the height multiplied by the sum of the two sides, which is : {0}", TrapezoidArea);
    }
}

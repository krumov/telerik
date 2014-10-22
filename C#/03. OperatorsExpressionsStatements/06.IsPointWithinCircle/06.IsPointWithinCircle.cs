using System;

class IsPointWithinCircle
{
    static void Main(string[] args)

        //Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
        
    {
        Console.WriteLine("Please enter X & Y coordinates:");

        Console.Write("X: ");
        int coordinateX = int.Parse(Console.ReadLine());

        Console.Write("Y: ");
        int coordinateY = int.Parse(Console.ReadLine());
        
        int circleRadius = 5;

        if (((coordinateX * coordinateX) + (coordinateY * coordinateY)) <= (circleRadius * circleRadius))
        {
            Console.WriteLine("The given point is within a circle with a radius of 5!");
        }
        else
        {
            Console.WriteLine("The given point is not within a circle with a radius of 5!");
        }
    }
}

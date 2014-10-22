using System;

class PrintPerimiterAndAreaOfCircle
//Write a program that reads the radius r of a circle and prints its perimeter and area.

{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the radius of the circle r=: ");
        double radius = double.Parse(Console.ReadLine());

        double circlePerimeter = 2 * Math.PI * radius;
        double circleArea = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("The perimeter ot the circle is {0}", circlePerimeter);
        Console.WriteLine("The area of the circle is {0}", circleArea);
    }
}

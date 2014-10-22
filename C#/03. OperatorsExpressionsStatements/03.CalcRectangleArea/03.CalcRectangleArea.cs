using System;

class CalcRectangleArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the rectangles' Width: ");
        int Width = int.Parse(Console.ReadLine());

        Console.WriteLine("Write the rectangles' Height: ");
        int Height = int.Parse(Console.ReadLine());

        int RectangleArea = Width * Height / 2;

        Console.WriteLine("The rectangles' area is the width times the height dividet by 2, which is : {0}", RectangleArea);
    }
}

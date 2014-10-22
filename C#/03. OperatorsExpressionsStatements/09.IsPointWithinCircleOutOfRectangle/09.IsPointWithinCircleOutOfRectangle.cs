using System;

class IsPointWithinCircleOutOfRectangle
{
    static void Main(string[] args)

        //Write an expression that checks for given point (x, y) if it is within the circle K((1,1), 3)
        //and out of the rectangle R(top=1, left=-1, width=6, height=2).

    {
        double raduis = 3;
        Console.WriteLine("Enter X coordinate");
        double coordinateX = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate");
        double coordinateY = double.Parse(Console.ReadLine());

        bool isInCircle = (((coordinateX - 1) * (coordinateX - 1)) + ((coordinateY - 1) * (coordinateY - 1)) <= raduis*raduis);
        bool isOutOfRectangle = ((1 > coordinateX || coordinateX < 4) && (-1 < coordinateY || coordinateY < -3));

        if (isInCircle && isOutOfRectangle)
        {
            Console.WriteLine("The Point is IN the circle and OUT of the rectangle");
        }
        else
        {
            Console.WriteLine("The Point is either OUT of the circle or IN the rectangle");
        }
    }
}


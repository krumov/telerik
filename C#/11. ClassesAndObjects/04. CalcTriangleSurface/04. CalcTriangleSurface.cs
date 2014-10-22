using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

class CalcTriangleSurface
{
    static void Main(string[] args)
    {
        Console.WriteLine("We are going to calculate the surface of a triangle,\n");
        Console.WriteLine("Enter 1 if you want to use a side and the altitude to it");
        Console.WriteLine("Enter 2 if you want to use the three sides of the triangle"); 
        Console.WriteLine("Enter 3 if you want to use two sides and the angle between them");

        Console.Write("\nYour choise: ");

        string input = Console.ReadLine();
        Console.WriteLine();

        if (input != "1" && input != "2" && input != "3")
        {
            do
            {
                Console.WriteLine("You have to enter 1,2 or 3 - try again\nYour choise: ");
                input = Console.ReadLine();

            } while (input != "1" && input != "2" && input != "3");
        }

        int userChoise = int.Parse(input);

        if (userChoise == 1)
        {
            
            Console.Write("Enter the side of the triangle: ");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the altitude to the side: ");
            double altitude = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double area = (side * altitude) / 2;

            Console.WriteLine("The surface is: {0}", area);

        }

        else if (userChoise == 2)
        {
            Console.Write("Enter the first side of the triangle: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the second side of the triangle: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the third side of the triangle: ");
            double sideC = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double p = (sideA + sideB + sideC) / 2;

            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            Console.WriteLine("The surface is: {0}", area);
        }

        else
        {
            Console.Write("Enter the first side of the triangle: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the second side of the triangle: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the angle between them: ");
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double sin = Math.Sin((angle * Math.PI) / 180);

            double area = ((sideA * sideB * sin) / 2);

            Console.WriteLine("The surface is: {0}", area);

        }
        Console.WriteLine();
    }
}

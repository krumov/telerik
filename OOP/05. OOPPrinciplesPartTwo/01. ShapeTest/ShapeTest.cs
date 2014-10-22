using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShapeTest
{
    class ShapeTest
    {
        static void Main(string[] args)
        {
             Triangle triangle = new Triangle(6, 4);
             Rectangle rectangle = new Rectangle(6,4);
             Circle circle = new Circle(6);

            List<Shape> testList = new List<Shape>() 
            {
               triangle,rectangle,circle
            };

            foreach (var item in testList)
            {
                Console.WriteLine(item.CalculateSurface());
            }

        }
    }
}

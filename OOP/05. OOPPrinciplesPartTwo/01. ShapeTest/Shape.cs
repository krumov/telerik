using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShapeTest
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();

    }
}

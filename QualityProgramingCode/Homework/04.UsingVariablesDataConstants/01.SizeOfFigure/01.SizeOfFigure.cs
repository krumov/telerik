using System;

namespace _01.SizeOfFigure
{

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Size GetRotatedSize(Size currentSize, double angleOfFigure)
        {
            double newWidth = (Math.Abs(Math.Cos(angleOfFigure)) * currentSize.Width) +
                (Math.Abs(Math.Sin(angleOfFigure)) * currentSize.Height);
            double newHeight = (Math.Abs(Math.Sin(angleOfFigure)) * currentSize.Width) +
                (Math.Abs(Math.Cos(angleOfFigure)) * currentSize.Height);

            return new Size(newWidth, newHeight);
        }
    }
}

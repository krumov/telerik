namespace ComputerParts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VideoCardMonochrome : IVideoCard
    {
        public void Draw(string message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
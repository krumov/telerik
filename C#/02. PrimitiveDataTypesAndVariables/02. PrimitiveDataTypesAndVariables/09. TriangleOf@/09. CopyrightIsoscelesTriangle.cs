using System;

class CopyrightIsoscelesTriangle
{
    static void Main()
    {
        const char copyright = '\u00a9';
        const int symbolsCount = 9;

        DrawIsoscelesTriangle(copyright, symbolsCount);
    }

    public static void DrawIsoscelesTriangle(char symbol, int symbolsCount)
    {
        double triangleHeight = Math.Sqrt(symbolsCount);

        if (triangleHeight - (int)triangleHeight > 0.001)
            throw new Exception("Invalid symbols count.");

        int symbolsToMoveNextLine = 1;
        int currentHeight = 0;
        int topElementIndex = symbolsCount / 2 + (int)triangleHeight / 2 - 1;

        for (int i = 0; i < symbolsCount; i++)
        {
            Console.Write(symbol + " ");
            currentHeight++;

            if (currentHeight == symbolsToMoveNextLine)
            {
                Console.WriteLine();

                symbolsToMoveNextLine = i < topElementIndex
                        ? symbolsToMoveNextLine + 1
                        : symbolsToMoveNextLine - 1;

                currentHeight = 0;
            }
        }

        Console.WriteLine();
    }
}



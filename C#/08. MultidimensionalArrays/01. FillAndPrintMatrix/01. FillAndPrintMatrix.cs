using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

class FillAndPrintMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many rows and columns do you want the matrix to have?");
        int arraySize = int.Parse(Console.ReadLine());

        int[,] matrix = new int[arraySize, arraySize];
        int number = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = number;
                number++;
            }
        }

        Console.WriteLine("Variant A:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] < 10)
                {
                    Console.Write("  {0}", matrix[row, col]);
                }
                else
                    Console.Write(" {0}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        // Variant B
        number = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    matrix[row, col] = number;
                    number++;

                }
            }
            else
            {
                for (int row = arraySize - 1; row >= 0; row--)
                {
                    matrix[row, col] = number;       
                    number++;
                }
            }
        }

        Console.WriteLine("Variant B:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] < 10)
                {
                    Console.Write("  {0}", matrix[row, col]);
                }
                else
                    Console.Write(" {0}", matrix[row, col]);
            }
            Console.WriteLine();
        }

    }
}


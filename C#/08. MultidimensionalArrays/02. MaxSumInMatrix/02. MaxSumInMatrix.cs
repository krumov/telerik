using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.


class MaxSumInMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write how many rows the matrix should have");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Write how many columns the matrix should have");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        int highestSumRow = 0;
        int highestSumCol = 0;
            
        Console.WriteLine("Please enter the numbers in the marix:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("martix [{0},{1}]",row,col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        int bestSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                if (sum>bestSum)
                {
                    bestSum = sum;
                    highestSumRow = row;
                    highestSumCol = col;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("The square with the hughest sum has a sum of {0} and looks like this:", bestSum);
        Console.WriteLine();

        for (int row = highestSumRow; row < highestSumRow + 3; row++)
        {
            for (int col = highestSumCol; col < highestSumCol + 3; col++)
            {
                Console.Write(" {0}", matrix[row, col]);
            }

            Console.WriteLine();
        }

    }
}


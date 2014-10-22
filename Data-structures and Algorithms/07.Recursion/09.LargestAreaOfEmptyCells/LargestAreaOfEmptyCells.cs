﻿namespace _09.LargestAreaOfEmptyCells
{
    using System;
    using System.Linq;

    /*
     * Write a recursive program to find the largest connected 
     * area of adjacent empty cells in a matrix.
     */

    class LargestAreaOfEmptyCells
    {
        static string[,] labyrinth = 
        {
            {" ", " ", " ", "*", " ", " ", " "},
            {"*", "*", " ", "*", " ", "*", " "},
            {" ", " ", " ", "*", " ", " ", " "},
            {" ", "*", "*", "*", "*", "*", " "},
            {" ", " ", " ", "*", " ", " ", " "},
        };

        static void Main(string[] args)
        {

            FindBiggestArea(labyrinth.GetLength(0), labyrinth.GetLength(1));
        }

        static void FindBiggestArea(int rows, int cols)
        {
            int step = 0;
            int count = 0, maxCount = 0, number = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (labyrinth[i, j] == " ")
                    {
                        FindArea(i, j, step, ref count);
                        if (count >= maxCount)
                        {
                            maxCount = count;
                            number = step;
                        }
                        count = 0;
                        step++;
                    }
                }
            }

            PrintLabyrint(number.ToString());
            Console.WriteLine("Biggest area is {0}'s", number);
            Console.WriteLine("with count {0}", maxCount);
        }


        static void FindArea(int row, int col, int step, ref int count)
        {
            if (row < 0 || col < 0 ||
                row >= labyrinth.GetLength(0) || col >= labyrinth.GetLength(1))
            {
                return;
            }

            if (labyrinth[row, col] != " ")
            {
                return;
            }

            labyrinth[row, col] = step.ToString();
            count++;

            FindArea(row, col - 1, step, ref count);
            FindArea(row - 1, col, step, ref count);
            FindArea(row, col + 1, step, ref count);
            FindArea(row + 1, col, step, ref count);
        }

        static void PrintLabyrint(string number)
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j] == number || labyrinth[i, j] == "*")
                    {
                        Console.Write("{0, 2} ", labyrinth[i, j]);
                    }
                    else
                    {
                        Console.Write("{0, 2} ", " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

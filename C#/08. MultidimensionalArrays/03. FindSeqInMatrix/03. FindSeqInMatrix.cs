using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
//neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. Example:


class StringSequences
{
    static string[,] stringsArray;

    static void PrintArray()
    {
        for (int row = 0; row < stringsArray.GetLength(0); row++)
        {
            for (int col = 0; col < stringsArray.GetLength(1); col++)
            {
                Console.Write(" {0, 3}", stringsArray[row, col]);
            }

            Console.WriteLine();
        }
    }

    static int GetSequenceLength(int row, int col, string direction)
    {
        int currentLength = 1;
        int nextRow = 0;
        int nextCol = 0;

        // Adjust the next cell to the direction
        if (direction == "down")
        {
            nextRow = 1;
        }
        else if (direction == "right")
        {
            nextCol = 1;
        }
        else if (direction == "diagonal-right")
        {
            nextRow = 1;
            nextCol = 1;
        }
        else
        {
            nextRow = 1;
            nextCol = -1;
        }

        while (true)
        {
            // Check if we are at out of boundaries and break the loop if we are
            if (row == stringsArray.GetLength(0) || col == stringsArray.GetLength(1) || row < 0 || col < 0)
            {
                break;
            }

            // Check if we are at the end of a row or column and break the loop if we are
            string nextCell = null;

            try
            {
                nextCell = stringsArray[row + nextRow, col + nextCol];
            }
            catch (IndexOutOfRangeException)
            {
                break;
            }

            string currentCell = stringsArray[row, col];
            nextCell = stringsArray[row + nextRow, col + nextCol];

            if (currentCell == nextCell)
            {
                currentLength++;
            }
            else
            {
                break;
            }

            row += nextRow;
            col += nextCol;
        }

        return currentLength;
    }

    static void Main()
    {
        /* We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements
* located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix */

        //// Get N and M from the user and initiate the array
        Console.Write("Please enter how many rows should the array have: ");
        int arrayRows = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nPlease enter how many columns should the array have: ");
        int arrayCols = Convert.ToInt32(Console.ReadLine());

        stringsArray = new string[arrayRows, arrayCols];

        //// Get the numbers from the console
        for (int row = 0; row < stringsArray.GetLength(0); row++)
        {
            Console.Write("\nPlease enter the number in Row {0}: \n", (row + 1));

            for (int col = 0; col < stringsArray.GetLength(1); col++)
            {
                string currentString = Console.ReadLine();
                stringsArray[row, col] = currentString;
            }
        }

        //// Print the entered array
        Console.WriteLine("\nYou have entered the following matrix: \n");
        PrintArray();

        // Check the sequence length of each cell by going down, right, diagonal-right and diagonal-left
        int longestSequenceLength = 1;
        string longestSequenceString = null;

        for (int row = 0; row < stringsArray.GetLength(0); row++)
        {
            for (int col = 0; col < stringsArray.GetLength(1); col++)
            {
                // Check the length of the sequences from the current cell in all directions and compare them to the longest one
                for (int directionCase = 1; directionCase <= 4; directionCase++)
                {
                    string direction = null;

                    switch (directionCase)
                    {
                        case 1: direction = "down"; break;
                        case 2: direction = "right"; break;
                        case 3: direction = "diagonal-right"; break;
                        case 4: direction = "diagonal-left"; break;
                        default: break;
                    }

                    // Get the sequence length of the current cell in the current direction
                    int currentSequenceLength = GetSequenceLength(row, col, direction);

                    // Compare it to the longest sequence
                    if (currentSequenceLength >= longestSequenceLength)
                    {
                        longestSequenceLength = currentSequenceLength;
                        longestSequenceString = stringsArray[row, col];
                    }
                }
            }
        }

        // Print the longest string sequence
        Console.Write("\nThe longest string sequence is: ");

        for (int i = 0; i < longestSequenceLength; i++)
        {
            Console.Write("{0} ", longestSequenceString);
        }

        Console.WriteLine();
    }
}
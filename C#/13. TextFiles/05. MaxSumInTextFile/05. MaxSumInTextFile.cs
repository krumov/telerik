using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a text file containing a square matrix of numbers 
// and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
// The first line in the input file contains the size of matrix N. 
// Each of the next N lines contain N numbers separated by space. 
// The output should be a single number in a separate text file. Example:

class MaxSumInTextFile
{
  
    static int[,] ReadInputFile(string path)
    {
        int[,] matrix;

        using (StreamReader read = new StreamReader(path))
        {
            int matrixSize = int.Parse(read.ReadLine());
            matrix = new int[matrixSize, matrixSize];
            string line;
            string[] matrixRow = new string[matrixSize];
            int rowNumber = 0;
            while ((line = read.ReadLine()) != null)
            {
                matrixRow = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < matrixSize; i++)
                {
                    matrix[rowNumber, i] = int.Parse(matrixRow[i]);
                }
                rowNumber++;
            }
        }
        return matrix;
    }

       
    static int FindAreaWithMaxSum(int[,] matrix)
    {
        int maxSum = int.MinValue;

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        return maxSum;
    }

  
    static void WriteOutputFile(int maxSum)
    {
        using (StreamWriter write = new StreamWriter(@"..\..\result.txt"))
        {
            write.WriteLine(maxSum);
        }
    }

    static void Main(string[] args)
    {
     
            int[,] matrix = ReadInputFile(@"..\..\input.txt");
            int maxSum = FindAreaWithMaxSum(matrix);
            WriteOutputFile(maxSum);
                   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Matrix
{
    class MatrixClass
    {

        public class Matrix<T> where T :
          struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {

            private const int DefaultSize = 8;
            public int Row { get; private set; }
            public int Col { get; private set; }
            private T[,] matrix;

            public Matrix()
            {
                matrix = new T[DefaultSize, DefaultSize];
            }

            public Matrix(int row, int col)
            {
                if (row < 0 || col < 0) throw new ArgumentOutOfRangeException("Row or col value can not be negative!");
                else
                {
                    this.Row = row;
                    this.Col = col;
                    matrix = new T[row, col];
                }
            }

            public Matrix(T[,] matrix)
            {
                this.matrix = matrix;
                Row = matrix.GetLength(0);
                Col = matrix.GetLength(1);
            }

            public T this[int row, int col]
            {
                get
                {
                    if (Row < row || Col < col || row < 0 || col < 0) throw new ArgumentOutOfRangeException("Index out of range for Row or Col");
                    else return matrix[row, col];
                }
                set
                {
                    if (Row < row || Col < col || row < 0 || col < 0) throw new ArgumentOutOfRangeException("Index out of range for Row or Col");
                    else matrix[row, col] = value;
                }
            }

            public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
            {
                if (first.Row == second.Row && first.Col == second.Col)
                {
                    Matrix<T> tempArr = new Matrix<T>(first.Row, first.Col);
                    for (int i = 0; i < first.Row; i++)
                    {
                        for (int j = 0; j < first.Col; j++)
                        {
                            checked
                            {
                                tempArr[i, j] = (dynamic)first[i, j] + second[i, j];
                            }
                        }
                    }
                    return tempArr;
                }
                else throw new Exception("The given matrix are not the same size");
            }

            public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
            {
                if (first.Row == second.Row && first.Col == second.Col)
                {
                    Matrix<T> tempArr = new Matrix<T>(first.Row, first.Col);
                    for (int i = 0; i < first.Row; i++)
                    {
                        for (int j = 0; j < first.Col; j++)
                        {
                            checked
                            {
                                tempArr[i, j] = (dynamic)first[i, j] - second[i, j];
                            }
                        }
                    }
                    return tempArr;
                }
                else throw new Exception("The given matrix are not the same size");
            }

            public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
            {
                if (first.Col == second.Row && (first.Row > 0 && second.Col > 0 && first.Col > 0))
                {
                    Matrix<T> final = new Matrix<T>(first.Row, second.Col);
                    for (int i = 0; i < final.Row; i++)
                    {
                        for (int j = 0; j < final.Col; j++)
                        {
                            final[i, j] = (dynamic)0;
                            for (int k = 0; k < first.Col; k++)
                            {
                                checked
                                {
                                    final[i, j] = final[i, j] + (dynamic)first[i, k] * second[k, j];
                                }
                            }
                        }
                    }
                    return final;
                }
                else
                {
                    throw new Exception("Row on the first matrix and col on the second matrix, are with different size, multiplication cannot be done.");
                }
            }
           
            public override string ToString()
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        builder.Append(matrix[i, j] + " ");
                    }
                    builder.AppendLine();
                }
                return builder.ToString();
            }
        }

        static void Main(string[] args)
        {
        }
    }
}

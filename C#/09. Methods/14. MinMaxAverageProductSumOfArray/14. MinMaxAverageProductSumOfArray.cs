using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

class MinMaxAverageProductSumOfArray
{
    static int Min(int[] array)
    {
        int arrayLength = array.Length;
        int result = array[0];

        for (int i = 1; i < arrayLength; ++i)
        {
            result = Math.Min(result, array[i]);
        }
        return result;
       
    }

    static int Max(int[] array)
    {
        int arrayLength = array.Length;
        int result = array[0];

        for (int i = 1; i < arrayLength; ++i)
        {
            result = Math.Max(result, array[i]);
        }
        return result;
    }

    static int Sum(int[] array)
    {
        int sum = 0;
        foreach (int x in array)
        {
            sum += x;
        }
        return sum;
    }

    static int Average(int[] array)
    {
        int sum = 0, sequenceLength = array.Length;
        foreach (int x in array)
        {
            sum += x;
        }

        return sum / sequenceLength;
    }

    static int Product(int[] array)
    {
        int product = 1;
        foreach (int x in array)
        {
            product *= x;
        }

        return product;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter how many numbers do you want the array to have: ");
        int arraySize = int.Parse(Console.ReadLine());
    
        int[] array = new int[arraySize];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Number {0} in array: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nThe minimal number in the array is: {0}", Min(array));
        Console.WriteLine("The maximal number in the array is: {0}", Max(array));
        Console.WriteLine("The sum of the numbers in the array is: {0}", Sum(array));
        Console.WriteLine("The product of the numbers in the array is: {0}", Product(array));
        Console.WriteLine("The average of the numbers in the array is: {0}", Average(array));
    }
}


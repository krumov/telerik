using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.

class MaxElementOfArray
{
    static int MaxInArray(int[] array, int position) // works
    {
        int maxElement = int.MinValue;

        for (int i = position; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }
        } 

        return maxElement;
    }

    static int[] SortArrayDescending(int[] array)//does not work>???
    {
        int maxElemen = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            maxElemen = MaxInArray(array, i); 
            array[i] = maxElemen;
            maxElemen = int.MinValue;
        }

        return array;
    }

    static void Main(string[] args)
    {
        int[] array = new int[5];

        //test
        for (int i = 0; i < 5; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(SortArrayDescending(array));
    }
}


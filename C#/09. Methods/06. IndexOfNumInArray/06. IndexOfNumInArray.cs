using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

class IndexOfNumInArray
{
    static bool isBigger(int[] array, int position)
    {
        bool isBigger = false;

        if (position != 0 && position != array.Length - 1)
        {
            if (array[position] > array[position + 1] && array[position] > array[position - 1])
            {
                isBigger = true;
            }

            return isBigger;
        }
        else
            return isBigger;
    }

    static int FindIndex(int[] array)
    {
        
        for (int i = 1; i < array.Length-1; i++)
        {
            if (isBigger(array,i))
            {
                return i;
            }          
        }

        return -1;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter how many numbers do you want the array to have: ");
        int arraySize = int.Parse(Console.ReadLine());
        
        int[] array = new int[arraySize];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Number at position {0} in array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        if (FindIndex(array) != -1)
        {
            Console.WriteLine("\nThe number at position {0} in the array is the first that is bigger than its neighbors\n", FindIndex(array));
        }
        else
            Console.WriteLine("\nThere is no number in the array that is bigger than its neighbors\n");
    }
}


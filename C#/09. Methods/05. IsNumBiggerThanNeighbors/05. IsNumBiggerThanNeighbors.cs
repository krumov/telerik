using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

class IsNumBiggerThanNeighbors
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

    static void Main(string[] args)
    {
        Console.Write("Enter how many numbers do you want the array to have: ");
        int arraySize = int.Parse(Console.ReadLine());
        int posToFind;

        int[] array = new int[arraySize];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Number at position {0} in array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nWhich position do you want to check in the array: ");

        posToFind = int.Parse(Console.ReadLine());

        if (isBigger(array,posToFind))
        {
            Console.WriteLine("\nThe number at the position you etered IS bigger then its neighbors\n");
        }
        else
            Console.WriteLine("\nThe number at the position you etered IS NOT bigger then its neighbors or does not have two neighbors\n");
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayByStringLength
{
    static string[] SortArrayByStringLength(string[] arrayToSort)
    {
        // Put the all different lengths of the elements of the array into a list
        List<int> lengthsOfElements = new List<int>();

        for (int index = 0; index < arrayToSort.Length; index++)
        {
            int lenghtOfCurrentElement = arrayToSort[index].Length;
            lengthsOfElements.Add(lenghtOfCurrentElement);
        }

        // Sort the list and remove any duplicate values in the list
        lengthsOfElements.Sort();

        for (int index = (lengthsOfElements.Count - 1); index > 0; index--)
        {
            if (lengthsOfElements[index] == lengthsOfElements[index - 1])
            {
                lengthsOfElements.RemoveAt(index);
            }
        }

        // Interate through the sorted list and put the elements of the original array to a new one that have the same lenght as the elements of the list
        string[] sortedArray = new string[arrayToSort.Length];
        int nextAvailablePositionInSortedArray = 0;

        for (int listIndex = 0; listIndex < lengthsOfElements.Count; listIndex++)
        {
            for (int arrayIndex = 0; arrayIndex < arrayToSort.Length; arrayIndex++)
            {
                int lenghtOfCurrentElement = arrayToSort[arrayIndex].Length;

                if (lenghtOfCurrentElement == lengthsOfElements[listIndex])
                {
                    sortedArray[nextAvailablePositionInSortedArray] = arrayToSort[arrayIndex];
                    nextAvailablePositionInSortedArray++;
                }
            }
        }

        return sortedArray;
    }

    static void Main()
    {
        // You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

        // Get the array from the console
        Console.Write("Please enter how many words you want to compare: ");
        int numberOfWords = Convert.ToInt32(Console.ReadLine());

        string[] stringsArray = new string[numberOfWords];

        Console.WriteLine("\nPlease enter the word you wish to compare: \n");
        for (int index = 0; index < stringsArray.Length; index++)
        {
            string currentSring = Console.ReadLine();

            stringsArray[index] = currentSring;
        }

        //Sort the array using the method
        stringsArray = SortArrayByStringLength(stringsArray);

        // Print the sorted array
        Console.WriteLine("\nThe words you have entered sorted by their length are: \n");

        for (int index = 0; index < stringsArray.Length; index++)
        {
            Console.WriteLine("\"{0}\" ", stringsArray[index]);
        }

        Console.WriteLine();
    }
}


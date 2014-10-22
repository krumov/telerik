using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the
//method Array.BinSearch() finds the largest number in the array which is ≤ K. 


class FindGivenNumInMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many numbers do you want the array to have?");
        int arraySize = int.Parse(Console.ReadLine());
        Console.Write("Enter K=");
        Console.WriteLine();
        int K = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the numbers in the array:\n");
        int[] array = new int[arraySize];
            
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        bool answerFound = false;
        int answer = 0;

        // To find the number that is closest(or equal) to K we start searching from K. 
        //If there is a number equal to K we are done and we break, if not we try with K-1 if not K-2 and so on 
        //until we find the closest to K number in our martix. 
        for (int i = K; i >= array[0]; i--)
        {
            if (Array.BinarySearch(array, i) >= 0)
            {
                answer = array[Array.BinarySearch(array, i)];
                answerFound = true;
                break;
            }
        }
            
        if (answerFound)
        {
            Console.WriteLine("\nThe largest number in the array that is <= K is {0}\n", answer);
        }
        else
        {
            Console.WriteLine("\nThere is no number in the array that is <= K\n");
        }
    }
}


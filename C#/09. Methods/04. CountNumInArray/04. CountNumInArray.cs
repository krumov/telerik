using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

class CountNumInArray
{
    static int HowManyNums(int[] array, int num)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==num)
            {
                counter++;
            }
        }

        return counter;

    }

    static void Main(string[] args)
    {
        Console.Write("Enter how many numbers do you want the array to have: ");
        int arraySize = int.Parse(Console.ReadLine());
        int numToFind;

        int[] array = new int[arraySize];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Number {0} in array: ", i+1);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nWhich number do you want to find in the array: ");

        numToFind = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe number {0} is repeated {1} times in the array.",numToFind,HowManyNums(array, numToFind)); 
    }
}


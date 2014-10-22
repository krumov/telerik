using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

class SortArrayInIncreasingOrder
{
    static void Main(string[] args)
    {
        Console.WriteLine("How big do you want the array to be?");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] arrayOne = new int[n];
       
        Console.WriteLine("Enter the numbers in the array");

        for (int i = 0; i < n; i++)
        {
            arrayOne[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arrayOne);

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine();
        Console.WriteLine("The numbers you entered, sorted in increasing order:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arrayOne[i]);
        }
    }
}

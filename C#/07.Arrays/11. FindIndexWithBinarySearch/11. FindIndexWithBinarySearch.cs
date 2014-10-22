using System;

//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

class FindIndexWithBinarySearch
{
    static void Main(string[] args)
    {
        Console.WriteLine("How big do you want the array to be?");
        Console.Write("Size=");
        int arraySize = int.Parse(Console.ReadLine());
        Console.WriteLine();

        
        int[] array = new int[arraySize];
        

        Console.WriteLine("Enter the numbers of the array");

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        Console.WriteLine("To which number do you want to find the index");
        int number = int.Parse(Console.ReadLine());

        int index = Array.BinarySearch(array, number); // Finds the index of the given number in an accending sorted array.

        Console.WriteLine("Number:{0} is at index:{1}", number,index);
        
        //int low = 0, high = array.Length - 1, midpoint = 0, value;

        //while (low <= high)
        //{
        //    midpoint = low + (high - low) / 2;

        //    // check to see if value is equal to item in array
        //    if (value == array[midpoint])
        //    {
        //        return midpoint;
        //    }
        //    else if (value < array[midpoint])
        //        high = midpoint - 1;
        //    else
        //        low = midpoint + 1;
        //}

        //// item was not found
        //return -1;

    }

    // Доста задачи липсват и тази последната не изпълниява точно условието 
    //( изкоментирания код е бинарния търсещ алгоритъм но не успях да го приложа навреме, но намерих този лесен и интересен начин) 
    //за съжаление не ми остана достатъчно време, приемам всякаква градивна критика за това което съм написал. 
}

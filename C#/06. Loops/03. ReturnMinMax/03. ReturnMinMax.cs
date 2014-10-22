using System;

class ReturnMinMax
//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
{
    static void Main(string[] args)
    {
        Console.Write("Enter how many numbers do you wish to have: ");
        int numbers = int.Parse(Console.ReadLine());

        int[] array = new int[numbers];
        Console.WriteLine("Enter your numbers, pressing enter after everyone");

        for (int i = 0; i < numbers; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine()); //we are making an array
        }

        int bigestNumber = -2147483648; // the lowest possible number when using int - everything else is bigger

        for (int i = 0; i < numbers; i++)
        {
            if (array[i] > bigestNumber)
            {
                bigestNumber = array[i]; // we are chekiing to see if the entered number is bigger than the last one, if it is - it takes it's plase
            }
        }

        Console.WriteLine("The bigest number from the ones you entered is: {0}", bigestNumber);

        for (int i = 0; i < numbers; i++)
        {
            if (array[i] < bigestNumber)
            {
                bigestNumber = array[i]; // we are doing the opposite of the previous if, to find the lowest number
            }
        }

        Console.WriteLine("The lowest number from the ones you entered is: {0}", bigestNumber);

    }
}

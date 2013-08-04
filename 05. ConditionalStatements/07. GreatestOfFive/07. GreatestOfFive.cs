using System;

class GreatestOfFive
{
    //Write a program that finds the greatest of given 5 variables.

    static void Main(string[] args)
    {
        int[] array = new int[5];
        Console.WriteLine("Enter 5 numbers, pressing enter after everyone");
        for (int i = 0; i <=4 ; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine()); //we are making an array ot 5 numbers
        }

        int bigestNumber = -2147483648; // the lowest possible number when using int - everything else is bigger

        for (int i = 0; i <= 4; i++)
        {
            if (array[i]> bigestNumber)
            {
                bigestNumber = array[i]; // we are chekiing to see if the entered number is bigger than the last one, if it is - it takes it's plase
            }
        }

        Console.WriteLine("The bigest number from the ones you entered is: {0}",bigestNumber);
    }
}


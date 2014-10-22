using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that can solve these tasks:
// *Reverses the digits of a number
// *Calculates the average of a sequence of integers
// *Solves a linear equation a * x + b = 0
// Create appropriate methods.
// Provide a simple text-based menu for the user to choose which task to solve.
// Validate the input data:
// *The decimal number should be non-negative
// *The sequence should not be empty
// *a should not be equal to 0

class ThreeTaskProgram
{
    static int ReverseDigits(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            reversed = reversed * 10 + num % 10;
            num = num / 10;
        }
        return reversed;
    }

    static double GetAverage(int[] array)
    {
        double sum = 0;
        double result;

        for (int i = 0; i < array.Length; i++) sum += array[i];

        result = sum / array.Length;

        return result;
    }

    static double CalculateEquation(int a, int b)
    {
        return (double)-b / a;
    }

    static void InputDigit()
    {
        Console.Write("Write the number you want reversed:");
        int num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            do
            {
                Console.Write("The number has to be non-negative - try again...\nnumber: ");
            num = int.Parse(Console.ReadLine());
            } while (num < 0); 
          
        }
      
        Console.WriteLine("\nThe reversed digit is: {0}\n", ReverseDigits(num));
    }

    static void InputArray()
    {
        Console.Write("How many numbers do you want the array to have: ");
        int arraySize;
        arraySize = int.Parse(Console.ReadLine());
        if (arraySize < 1)
        {
            do
            {
                Console.Write("The array has to be with atleast 1 member - try again...\nArray Size: ");
                arraySize = int.Parse(Console.ReadLine());

            } while (arraySize < 1);

            
        }
       
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Number {0} in array: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe average sum of the numbers you entered is: {0}\n", GetAverage(array));
        
    }

    static void InputEquation()
    {
        int a, b;
        Console.WriteLine("Input the coeficients 'a' and 'b' in the linear equation a*x + b = 0: ");
        Console.Write("a= ");
        a = int.Parse(Console.ReadLine());

        if (a == 0)
        {
            do
            {
                Console.WriteLine("The number can not be 0.... Try Again\na= ");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);
          
        }
       
        Console.Write("b= ");
        int.TryParse(Console.ReadLine(), out b);

        Console.WriteLine("X = {0}", CalculateEquation(a,b));
    
    }

    static void PrintMenu()
    {
        Console.WriteLine("+---------------------------------------------------+");
        Console.WriteLine("|1. Reverse the digits of a non negative number.    |");
        Console.WriteLine("|2. Calculate the avarage of a sequence of integers.|");
        Console.WriteLine("|3. Solve a linear equation a * x + b = 0 .         |");
        Console.WriteLine("+---------------------------------------------------+");
        Console.Write("Choose a task number: "); 
    }

    static void Main(string[] args)
    {
        int task;
       
        PrintMenu();

        task = int.Parse(Console.ReadLine());

        if (task == 1)
        {
            InputDigit();
        }
        else if (task == 2)
        {
            InputArray();
        }
        else
	    {
            InputEquation();
	    }

    }
}


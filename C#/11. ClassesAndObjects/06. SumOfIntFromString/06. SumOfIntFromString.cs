using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. Example:
//string = "43 68 9 23 318"  result = 461

class SumOfIntFromString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your numbers:\n");

        string nums = Console.ReadLine();

        string[] numArr = nums.Split(' ');

        int sum = 0;

        for (int i = 0; i < numArr.Length; i++)
        {
            sum = sum + int.Parse(numArr[i].Trim());
        }

        Console.WriteLine("\nThe sum of the numbers you entered is: {0}\n",sum);
    }
}

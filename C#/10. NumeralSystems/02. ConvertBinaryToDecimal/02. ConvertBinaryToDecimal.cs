using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert binary numbers to their decimal representation.

class ConvertBinaryToDecimal
{
   
    static void Main()
        {
            Console.Write("Write a binary number to convert to decimal: ");
            string numberToConvert = Console.ReadLine();//Read the input from the console
            Console.WriteLine("\nThe decimal representation is: {0}\n", ConvBinaryToDecimal(numberToConvert));
        }

    static int ConvBinaryToDecimal(string number) //Converts the number from binary to decimal numeral system
    {
        List<int> numberAsDigits = new List<int>();
        int decimalNumber = 0;
        bool isNegativeNum = false;

        foreach (char digit in number)//Output the digits from the string into the list
        {
            numberAsDigits.Add((digit - '0'));
        }

        if (numberAsDigits.Count == 32 && numberAsDigits[0] == 1) //Check if the binary number is negative(i.e. the 32nd position is 1 from signed magnitude theory)
        {
            isNegativeNum = true;
            numberAsDigits.RemoveAt(0); //Remove from the list the 32nd position (0 in the list index)
        }

        for (int i = numberAsDigits.Count - 1, power = 0; i >= 0; i--, power++)
        {
            decimalNumber += numberAsDigits[i] * (int)(Math.Pow(2, power));
        }

        if (isNegativeNum == true)
        {
            decimalNumber *= -1;
        }

        return decimalNumber;
    }
}



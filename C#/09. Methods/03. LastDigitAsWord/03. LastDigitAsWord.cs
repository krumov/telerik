using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

class LastDigitAsWord
{
    static void TypeDigit(int num)
    {
        int lastDigit = num % 10;
       
        switch (lastDigit)
        {
            case 1: Console.WriteLine("\nThe last digit of your number is One\n"); break;
            case 2: Console.WriteLine("\nThe last digit of your number is Two\n"); break;
            case 3: Console.WriteLine("\nThe last digit of your number is Three\n"); break;
            case 4: Console.WriteLine("\nThe last digit of your number is Four\n"); break;
            case 5: Console.WriteLine("\nThe last digit of your number is Five\n"); break;
            case 6: Console.WriteLine("\nThe last digit of your number is Six\n"); break;
            case 7: Console.WriteLine("\nThe last digit of your number is Seven\n"); break;
            case 8: Console.WriteLine("\nThe last digit of your number is Eight\n"); break;
            case 9: Console.WriteLine("\nThe last digit of your number is Nine\n"); break;
            case 0: Console.WriteLine("\nThe last digit of your number is Zero\n"); break;
            default:
                break;
        }
        
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number bigger than 10");
        Console.Write("\nNumber: ");
        int num = int.Parse(Console.ReadLine());

        TypeDigit(num);
    }
}


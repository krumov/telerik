using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
// Write a program that reads an integer number and calculates and prints its square root. 
// If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

class PrintSqrt
{


    static void Main(string[] args)
    {
       
        try
        {
            Console.Write("Write a number to find its square root: ");
            uint num = uint.Parse(Console.ReadLine());
            double numSqrt = Math.Sqrt(num);
            Console.WriteLine("The square of {0} is {1}", num,numSqrt);
        }
        catch (ArgumentNullException)
        {
            Console.Error.WriteLine("Invalid number");
        }

        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number");
        }

        catch (System.ArithmeticException)
        {
            Console.Error.WriteLine("Invalid number");
        }

      
        finally
        {
            Console.WriteLine("Good bye");
        }

    }
}


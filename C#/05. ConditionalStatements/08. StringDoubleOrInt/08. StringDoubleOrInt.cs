using System;

class StringDoubleOrInt
{
    /* Write a program that, depending on the user's choice inputs int, double or string variable. 
       If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
       The program must show the value of that variable as a console output. Use switch statement.
     */

    static void Main(string[] args)
      
          
    {
        Console.Write("Please enter int, double or string: ");
        string userInput = Console.ReadLine();
        int intChoise;
        double doubleChoise;

        if (int.TryParse(userInput, out intChoise))
        {
            Console.WriteLine(intChoise+1);
        }
        else if (double.TryParse(userInput, out doubleChoise))
        {
            Console.WriteLine(doubleChoise + 1);
        }
        else
        {
            Console.WriteLine(userInput + "*");
        }
     
            
    }
}


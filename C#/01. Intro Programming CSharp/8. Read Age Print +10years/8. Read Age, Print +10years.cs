using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write your age");

        string Age = Console.ReadLine();
        int value;
        if (int.TryParse(Age, out value)) 
            {
                Console.Write("In 10 years you will be " + (value + 10) +" years old"+ " ");
            }
        else
            {
                Console.WriteLine("Enter your age in numbers");
            }

    }
}

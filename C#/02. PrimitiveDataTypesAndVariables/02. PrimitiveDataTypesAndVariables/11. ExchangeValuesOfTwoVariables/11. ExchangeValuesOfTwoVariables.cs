using System;


class ExchangeValuesOfTwoVariables
{
    static void Main()
    {
        int Number1 = 5;
        int Number2 = 10;
        Number1 = Number1 + Number2;
        Number2 = Number1 - Number2;
        Number1 = Number1 - Number2;
        Console.WriteLine("Ther first number is {0}, and the second number is {1}", Number1, Number2);

    }
}



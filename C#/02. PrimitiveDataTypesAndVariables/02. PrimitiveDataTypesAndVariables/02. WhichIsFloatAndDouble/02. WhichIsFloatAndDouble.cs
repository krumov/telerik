using System;

class WhichIsFloatAndDouble
{
    static void Main(string[] args)
    {
        double numberA = 34.567839023;
        float numberB = 12.345f;
        double numberC = 8923.1234857;
        float numberD =3456.091f;
        Console.WriteLine("{0} is double, {1} is float, {2} is double, {3} is float", numberA, numberB, numberC, numberD);
    }
}

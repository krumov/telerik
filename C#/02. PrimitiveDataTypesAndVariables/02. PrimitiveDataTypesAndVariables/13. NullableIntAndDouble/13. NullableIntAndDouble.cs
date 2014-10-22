using System;


class NullableIntAndDouble
{
    static void Main()
    {
        int? nullableInt = null;
        Console.WriteLine(nullableInt + 1);
        Console.WriteLine(nullableInt + null);

        double? nullableDouble = null;
        Console.WriteLine(nullableDouble + 1);
        Console.WriteLine(nullableDouble + null);
        //The result from operations with null are null and the console prints nothing - even visual studio expresses a warning :)
    }
}



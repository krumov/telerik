using System;

class TwoStrings
{
    static void Main(string[] args)
    {
        string Hi = "Hello";
        string Everybody = "world!";
        object HiAll = Hi + " " + Everybody;

        //string result = (string)HiAll;
        string result = HiAll.ToString();
        Console.WriteLine(result);
    }
}

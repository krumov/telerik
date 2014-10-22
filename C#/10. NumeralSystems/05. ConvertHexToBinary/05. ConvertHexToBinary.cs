using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to binary numbers (directly).

class ConvertHexToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Please enter hexadecimal number without 0x...");
        string hexaNumber = Console.ReadLine();
        string result = "";

        for (int i = 0; i < hexaNumber.Length; i++)
        {
            switch (hexaNumber.Substring(i, 1))
            {
                case "0": result += "0000"; break;
                case "1": result += "0001"; break;
                case "2": result += "0010"; break;
                case "3": result += "0011"; break;
                case "4": result += "0100"; break;
                case "5": result += "0101"; break;
                case "6": result += "0110"; break;
                case "7": result += "0111"; break;
                case "8": result += "1000"; break;
                case "9": result += "1001"; break;
                case "a":
                case "A": result += "1010"; break;
                case "b":
                case "B": result += "1011"; break;
                case "c":
                case "C": result += "1100"; break;
                case "d":
                case "D": result += "1101"; break;
                case "e":
                case "E": result += "1110"; break;
                case "f":
                case "F": result += "1111"; break;
                default: result += ""; break;
            }
        }
        Console.WriteLine("\nThe binary representation is: {0}\n", result);
    }
}


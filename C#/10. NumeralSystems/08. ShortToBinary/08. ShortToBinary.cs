using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 
class ShortToBinary
{
    static List<int> ToBinary(int num)
    {
        int remainder;
        List<int> binaryNumber = new List<int>();

        do
        {
            remainder = num % 2;
            binaryNumber.Add(remainder);
            num = num / 2;
        } while (num != 0);

        binaryNumber.Reverse();
        return binaryNumber;
    }

    static void Main(string[] args)
    {
        Console.Write("Write a type short signed number to convert to binary: ");
        int num = int.Parse(Console.ReadLine());
        string binaryNum = "";

        if (num > 0)
        {
            List<int> binaryNumberArr = ToBinary(num);

            for (int i = 0; i < binaryNumberArr.Count; i++)
            {
                binaryNum += binaryNumberArr[i];
            }

            while (binaryNum.Length % 16 != 0)
            {
                binaryNum = "0" + binaryNum;
            }

            Console.WriteLine("\nThe binary representation of the number you entered is:\n\n{0}\n", binaryNum);
        }

        else if (num < 0)
        {
             num = Math.Abs(num) - 1;
             List<int> binaryNumberArr = ToBinary(num);

             for (int i = 0; i < binaryNumberArr.Count; i++)
             {
                 if (binaryNumberArr[i] == 0)
                 {
                     binaryNum += "1";
                 }
                 else
                 {
                     binaryNum += "0";
                 }
             }

             while (binaryNum.Length % 16 != 0)
             {
                 binaryNum = "1" + binaryNum;
             }

             Console.WriteLine("\nThe binary representation of the number you entered is:\n\n{0}\n", binaryNum);
        }

    }
}


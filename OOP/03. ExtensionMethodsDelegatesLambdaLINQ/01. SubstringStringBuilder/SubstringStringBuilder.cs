using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SubstringStringBuilder
{
    public static class Extension
    {
        public static StringBuilder substring(this StringBuilder stringBuilder, int index,int length)
        {
            StringBuilder outputStr = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                outputStr.Append(stringBuilder[i]);
            }

            return outputStr;
        }
        public static StringBuilder substring(this StringBuilder stringBuilder, int index)
        {
            StringBuilder outputStr = new StringBuilder();

            for (int i = index; i < stringBuilder.Length; i++)
            {
                outputStr.Append(stringBuilder[i]);
            }

            return outputStr;
        }


    }

    class SubstringStringBuilder
    {
        static void Main(string[] args)
        {
            StringBuilder testStr = new StringBuilder();
            testStr.Append("This is a test string - this shoud not be visable.");

            Console.WriteLine(testStr.substring(4,10));
          
        }
    }
}

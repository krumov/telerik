using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.ComparePerformance
{
    class SubstractMethods
    {
        public static void SubstractInt(int startValue, int endValue)
        {
            for (int i = startValue; i > endValue; )
            {
                i -= 2;
            }
        }
        public static void SubstractLong(long startValue, long endValue)
        {
            for (long i = startValue; i > endValue; )
            {
                i -= 2;
            }
        }
        public static void SubstractFloat(float startValue, float endValue)
        {
            for (float i = startValue; i > endValue; )
            {
                i -= 2;
            }
        }
        public static void SubstractDouble(double startValue, double endValue)
        {
            for (double i = startValue; i > endValue; )
            {
                i -= 2;
            }
        }
        public static void SubstractDecimal(decimal startValue, decimal endValue)
        {
            for (decimal i = startValue; i > endValue; )
            {
                i -= 2;
            }
        }
    }
}
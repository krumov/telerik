using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtensions
{
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> array)
        {
            dynamic sum = 0;
            foreach (var c in array)
            {
                sum += (dynamic)c;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> array)
        {
            dynamic product = 1;
            foreach (var c in array)
            {
                product *= (dynamic)c;
                if (product == 0)
                    break;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> array)
        {
            dynamic min = long.MaxValue;
            foreach (var c in array)
            {
                if (c < min)
                    min = c;
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> array)
        {
            dynamic max = long.MinValue;
            foreach (var c in array)
            {
                if (c > max)
                    max = c;
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> array)
        {
            dynamic average = 0, counter = 0;
            foreach (var c in array)
            {
                average += c;
                counter++;
            }
            if (counter == 0)
                throw new ArgumentException("The passed collection is empty.");
            return average / counter;
        }

    }

    class IEnumerableExtensions
    {
        static void Main(string[] args)
        {
        }
    }
}

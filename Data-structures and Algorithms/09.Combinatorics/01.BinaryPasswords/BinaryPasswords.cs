using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Combinatorics
{
    class BinaryPasswords
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var numberOfStars = input.Count(x => x.Equals('*'));

            long answer = 1;

            for (int i = 0; i < numberOfStars; i++)
            {
                answer *= 2;
            }

            Console.WriteLine(answer);
        }
    }
}

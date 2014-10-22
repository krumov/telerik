using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddTimesOccurancesOfString
{
    class OddTimesOccurancesOfString
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() {"C#", "SQL", "PHP", "PHP", "SQL", "SQL"} ;

            Console.WriteLine("The original numbers:\n" + string.Join(", ", strings) + "\n");

            Dictionary<string, int> occurences = new Dictionary<string, int>();

            for (int i = 0; i < strings.Count; i++)
            {
                if (!occurences.ContainsKey(strings[i]))
                {
                    occurences.Add(strings[i], 1);
                }
                else
                {
                    occurences[strings[i]]++;
                }
            }

            Console.WriteLine("The strings that occur odd times: ");

            var numsWithEvenOccurences = strings.Where(str => occurences[str] % 2 != 0).Distinct();

            Console.WriteLine(string.Join(", ", numsWithEvenOccurences) + "\n");
        }
    }
}

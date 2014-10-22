using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountWordsInFile
{
    class CountWordsInFile
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"../../words.txt");
            using (reader)
            {
                string text = reader.ReadToEnd();
                string[] words = text.Split(new char[] { '.', ',', '!', '?', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, int> occurs = new Dictionary<string, int>();

                foreach (var word in words)
                {
                    if (occurs.ContainsKey(word.ToLower()))
                    {
                        occurs[word.ToLower()]++;
                    }
                    else
                    {
                        occurs.Add(word.ToLower(), 1);
                    }
                }

                var sortedOccurs = occurs.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                // for this task cast to a Dictionary is not nessesary it works with return form lambda expressin key-value-pair too.

                foreach (var occur in sortedOccurs)
                {
                    Console.WriteLine("{0} -> {1} times", occur.Key, occur.Value);
                }

            }
        }
    }
}

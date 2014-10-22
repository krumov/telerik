using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ColorBunnies
{
    class ColorBunnies
    {
        static void Main(string[] args)
        {
            int numberOfBunnies = int.Parse(Console.ReadLine());

            List<int> bunnyAnswers = new List<int>();
            for (int i = 0; i < numberOfBunnies; i++)
            {
                bunnyAnswers.Add(int.Parse(Console.ReadLine()));
            }


            Dictionary<int, int> answerFrequency = new Dictionary<int, int>();

            for (int i = 0; i < bunnyAnswers.Count; i++)
            {
                if (!answerFrequency.ContainsKey(bunnyAnswers[i]+1))
                {
                    answerFrequency.Add(bunnyAnswers[i] + 1, 1);
                }
                else
                {
                    answerFrequency[bunnyAnswers[i] + 1]++;
                }
            }

            long answer = 0;

            foreach (var item in answerFrequency)
            {
                answer = answer + (int)(Math.Ceiling((double)item.Value/item.Key)*item.Key);
            }



            Console.WriteLine(answer);
        }
    }
}

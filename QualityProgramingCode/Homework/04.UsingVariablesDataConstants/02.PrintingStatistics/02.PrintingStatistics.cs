using System;


namespace _02.PrintingStatistics
{
    public class PrintingStatistics
    {
        public void PrintStatistics(double[] statisticsNumbers)
        {
            Console.WriteLine(this.PrintMaxValue(statisticsNumbers));
            Console.WriteLine(this.PrintMinValue(statisticsNumbers));
            Console.WriteLine(this.PrintAverageValue(statisticsNumbers));
        }

        public double PrintMaxValue(double[] statisticsNumbers)
        {
            double max = double.MinValue;
            for (int i = 0; i < statisticsNumbers.Length; i++)
            {
                if (statisticsNumbers[i] > max)
                {
                    max = statisticsNumbers[i];
                }
            }

            return max;
        }

        public double PrintMinValue(double[] statisticsNumbers)
        {
            double min = double.MaxValue;
            for (int i = 0; i < statisticsNumbers.Length; i++)
            {
                if (statisticsNumbers[i] < min)
                {
                    min = statisticsNumbers[i];
                }
            }

            return min;
        }

        public double PrintAverageValue(double[] statisticsNumbers)
        {
            double totalSum = 0;
            for (int i = 0; i < statisticsNumbers.Length; i++)
            {
                totalSum += statisticsNumbers[i];
            }

            double average = totalSum / statisticsNumbers.Length;

            return average;
        }
    }  
}

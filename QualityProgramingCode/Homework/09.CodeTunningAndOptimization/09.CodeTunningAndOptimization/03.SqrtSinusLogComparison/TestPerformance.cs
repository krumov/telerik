// Write a program to compare the performance of square root, 
// natural logarithm, sinus for float, double and decimal values.
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace _03.SqrtSinusLogComparison
{
    public class TestPerformance
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SqrtMethods.CalculateSqrtDouble(2d, 10000d, 0.002d);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for CalculateSqrtDouble: {0}", stopwatch.Elapsed);

            stopwatch.Start();
            SqrtMethods.CalculateSqrtDecimal(2m, 10000m, 0.002m);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for CalculateSqrtDecimal: {0}", stopwatch.Elapsed);

            stopwatch.Start();
            SqrtMethods.CalculateSqrtFloat(2f, 10000f, 0.002f);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for CalculateSqrtFloat: {0}", stopwatch.Elapsed);

            stopwatch.Start();
            LogMethods.CalculateLogDouble(2d, 10000d, 0.002d);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for CalculateLogDouble: {0}", stopwatch.Elapsed);

            stopwatch.Start();
            LogMethods.CalculateLogDecimal(2m, 10000m, 0.002m);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for CalculateLogDecimal: {0}", stopwatch.Elapsed);

            stopwatch.Start();
            LogMethods.CalculateLogFloat(2f, 10000f, 0.002f);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for CalculateLogFloat: {0}", stopwatch.Elapsed);

            stopwatch.Start();
            SinusMethods.CalculateSinDouble(2d, 10000d, 0.002d);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for CalculateSinDouble: {0}", stopwatch.Elapsed);

            stopwatch.Start();
            SinusMethods.CalculateSinDecimal(2m, 10000m, 0.002m);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for CalculateSinDecimal: {0}", stopwatch.Elapsed);

            stopwatch.Start();
            SinusMethods.CalculateSinFloat(2f, 10000f, 0.002f);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for CalculateSinFloat: {0}", stopwatch.Elapsed);
        }
    }
}
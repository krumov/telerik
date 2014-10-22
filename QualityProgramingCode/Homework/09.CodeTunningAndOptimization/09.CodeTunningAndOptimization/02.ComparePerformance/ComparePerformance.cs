// Write a program to compare the performance of add, subtract, 
// increment, multiply, divide for int, long, float, double and decimal values.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _02.ComparePerformance;
using System.Diagnostics;

namespace ComparePerfArithmeticPrimitiveValues
{
    class TestPerformance
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            AddMethods.AddDecimal(4m, 500000m);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for adddecimal: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            AddMethods.AddDouble(4d, 500000d);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for AddDouble: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            AddMethods.AddFloat(4f, 500000f);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for AddFloat: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            AddMethods.AddInt(4, 500000);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for AddInt: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            AddMethods.AddLong(4L, 500000L);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for AddLong: {0}", stopwatch.Elapsed);

            stopwatch.Start();
            SubstractMethods.SubstractDecimal(500000m, 4m);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for SubstractDecimal: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            SubstractMethods.SubstractDouble(500000d, 4d);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for SubstractDouble: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            SubstractMethods.SubstractFloat(500000f, 4f);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for SubstractFloat: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            SubstractMethods.SubstractInt(500000, 4);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for SubstractInt: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            SubstractMethods.SubstractLong(500000L, 4L);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for SubstractLong: {0}", stopwatch.Elapsed);


            stopwatch.Start();
            MultiplyMethods.MultiplyDecimal(2m, 500000m, 2m);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for MultiplyDecimal: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            MultiplyMethods.MultiplyDouble(2d, 500000d, 5d);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for MultiplyDouble: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            MultiplyMethods.MultiplyFloat(2f, 500000f, 5f);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for MultiplyFloat: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            MultiplyMethods.MultiplyInt(2, 500000, 5);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for MultiplyInt: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            MultiplyMethods.MultiplyLong(2L, 500000L, 5L);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for MultiplyLong: {0}", stopwatch.Elapsed);

            stopwatch.Start();
            DivideMethods.DivideDecimal(500000m, 4m, 2m);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for DivideDecimal: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            DivideMethods.DivideDouble(500000d, 4d, 2d);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for DivideDouble: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            DivideMethods.DivideFloat(500000f, 4f, 2f);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for DivideFloat: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            DivideMethods.DivideInt(500000, 4, 2);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for DivideInt: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            DivideMethods.DivideLong(500000L, 4L, 2L);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for DivideLong: {0}", stopwatch.Elapsed);
        }
    }
}
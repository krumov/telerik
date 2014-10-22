using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.TimerClass
{
    public delegate void TimerDelegate(int ticksCount); //declaring the delegate

    class Timer
    {
        public int TickCounter { get; private set; } //field with properties
        public int Interval { get; private set; } //field with properties
        private TimerDelegate callback; //new delegate field

        public Timer(int tickCounter, int interval, TimerDelegate callback) // constructor
        {
            this.TickCounter = tickCounter;
            this.Interval = interval;
            this.callback = callback;
        }

        public void Run() //method that sleeds every "interval" seconds
        {
            int ticks = this.TickCounter;
            while (ticks > 0)
            {
                Thread.Sleep(Interval);
                ticks--;
                this.callback(ticks);
            }
        }

    }


    class ExecuteAtEachSecond
    {
        static void Main()
        {
            TimerDelegate timerElapsedDelegate = new TimerDelegate(PrintMessage);

            Timer testTimer = new Timer(5, 2000, timerElapsedDelegate);

            Thread thread = new Thread(new ThreadStart(testTimer.Run));
            thread.Start();
        }

        public static void PrintMessage(int ticks)
        {
            Console.WriteLine("Hello, ticks left: {0}...", ticks);
        }
    }
}

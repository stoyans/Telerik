using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TimerAtTSeconds
{
    public delegate void SampleDelegate(int seconds);
    public class TimerDelegate
    {
        public static void TimerTest(int seconds)
        {
            Stopwatch interval = new Stopwatch();
            interval.Start();

            while (true)
            {
                if (interval.ElapsedMilliseconds == seconds * 1000)
                {
                    Console.WriteLine("Message");
                    interval.Restart();
                }
            }

        }
    }
}

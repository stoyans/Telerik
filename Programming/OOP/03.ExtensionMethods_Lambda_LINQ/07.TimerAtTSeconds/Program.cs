using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TimerAtTSeconds
{
    class Program
    {
        static void Main()
        {
            SampleDelegate test = new SampleDelegate(TimerDelegate.TimerTest);
            test(2);
        }
    }

}

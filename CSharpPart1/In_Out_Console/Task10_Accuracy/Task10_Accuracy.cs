using System;

namespace Task10_Accuracy
{
    class Task10_Accuracy
    {
        static void Main()
        {
            double sum = 1;
            double i = 2;
            //Цикълът ще работи докато 1/ i(което увеличаваме с 1 при всяко завъртане) не стане равна на 0.001
            while (1 / i >= 0.001)
            {
                if (i % 2 == 0)
                {
                    sum += (1 / i);
                }
                else
                {
                    sum -= (1 / i);
                }

                i++;
            }

            Console.WriteLine("Final sum = {0}",sum);
            
        }
    }
}

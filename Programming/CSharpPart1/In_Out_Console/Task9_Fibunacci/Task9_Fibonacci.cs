using System;
using System.Numerics;

namespace Task9_Fibunacci
{
    class Task9_Fibonacci
    {
        static void Main()
        {
            //променливите, с които ще работи, ги инициализираме от тип biginteger, тъй като не всички резултати ще се съберат в int
            BigInteger first = 0;
            BigInteger second = 1;
            BigInteger next;
            //Принтираме първите два члена на редицата
            Console.WriteLine("1 - {0}\n2 - {1}",first,second);

            for (int i = 3; i < 101; i++)
            {
                next = first + second; //Пресмятаме всяко следващо число от редицата
                first = second;
                second = next;
                Console.WriteLine("{0} - {1}", i, next);
            }

        }
    }
}

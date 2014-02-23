using System;

namespace Task_11_exchangeValues
{
    class Task_11_exchangeValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int temp = b;

            b = a;
            a = temp;

            Console.WriteLine("{0} and {1}", a ,b);
            
        }
    }
}

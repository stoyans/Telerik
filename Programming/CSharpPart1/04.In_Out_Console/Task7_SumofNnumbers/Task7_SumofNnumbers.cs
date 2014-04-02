using System;

namespace Task7_SumofNnumbers
{
    class Task7_SumofNnumbers
    {
        static void Main()
        {
            Console.Write("Enter value for n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = n;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} more number(s): ",count);
                int next = int.Parse(Console.ReadLine());
                count--;
                sum +=next;

            }
            Console.WriteLine("The sum of all numbers is: {0}", sum);
        }
    }
}

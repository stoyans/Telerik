using System;

class Program
{
    static void Main()
    {
        Console.Write("value of N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}


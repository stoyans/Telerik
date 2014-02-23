/*Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm*/

using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        Console.WriteLine("enter a num: ");
        uint n = uint.Parse(Console.ReadLine());
        ulong count = 0;
        DateTime stopwatch = DateTime.Now;


        int[] array = new int[n];
        bool[] check = new bool[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = i; //filling the array with numbers from 0 to n
            check[i] = true; //presume that all numbers are prime
        }
        
        for (long index = 2; index < n; index++) //start the loop with the first prime number, which is 2
        {
            if (check[index] == true) //the innder loop below will start from the next prime number ('true' element)
            {
                long num = array[index]; //in num we save the number in the current position which is true

                for (long i = num * num; i < n; i += num) //In this loop we 'mark' all numbers which are divisible to num. We start from num^2
                {                                         //and every next step is i+num, like it's described in the Eratosthenes algorithm
                    if (i % num == 0)                     //*the algorithm will work also if it's written: (i = num+1; i < n; i++) but will be extremely slow
                    {
                        check[i] = false; //if the number is NOT prime we "mark" it with false
                    }
                }
            }
        }

        TimeSpan time = DateTime.Now - stopwatch;
        Console.WriteLine(time);
        for (int j = 2; j < array.Length; j++)
        {
            if (check[j] == true)
            {
                //uncomment the row below to see the result
                //Console.WriteLine("{0} ", array[j]);
                count++;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("The amount of all prime numbers is: {0}",count);
    }
}


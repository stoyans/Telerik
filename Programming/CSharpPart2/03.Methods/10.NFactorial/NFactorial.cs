/*Write a program to calculate n! for each n in the range [1..100]. Hint: 
 * Implement first a method that multiplies a number represented as array of digits by given integer number.*/

using System;
using System.Collections.Generic;
using System.Text;

class _Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(string.Join("", Factorial(n)));
    }

    static int[] Factorial(int n)
    {
        //in numberFinal is saved every digit in the current iteration
        List<int> numberFinal = new List<int>();
        //in num is saved the value of the number after the multiplication
        string num = "1";

        //calculating the factorial
        for (int i = 1; i <= n; i++)
        {
            //clear the list and fill it again with the current iteration
            numberFinal.Clear();
            int carry = 0;

            for (int j = 0; j < num.Length; j++)
            {
                int currentDigit = num[j] - 48;

                if (currentDigit * i + carry > 9)
                {
                    numberFinal.Add(((currentDigit * i + carry) % 10));
                    carry = ((currentDigit * i + carry) / 10);
                }
                else
                {
                    numberFinal.Add(((currentDigit * i) + carry));
                    carry = 0;
                }
            }

            if (carry != 0)
            {
                if (carry > 9)
                {
                    while (carry >= 1)
                    {
                        byte remainder = (byte)(carry % 10);
                        carry /= 10;
                        numberFinal.Add(remainder);
                    }
                }
                else
                {
                    numberFinal.Add(carry);
                }

            }
            //saves current number
            num = string.Join("", numberFinal.ToArray());
        }

        //in array is saved the number after the last iteration
        int[] array = new int[numberFinal.Count];
        numberFinal.CopyTo(array);
        Array.Reverse(array);

        return array;
    }
}
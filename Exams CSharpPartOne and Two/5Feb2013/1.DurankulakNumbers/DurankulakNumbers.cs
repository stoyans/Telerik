using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace _1.DurankulakNumbers
{
    class DurankulakNumbers
    {
        static void Main()
        {
            string number = Console.ReadLine();

            string[] numbers = GenerateNumber();
            Console.WriteLine(FromDurankulakNumbers(number, numbers));
        }

        static string[] GenerateNumber()
        {
            string[] DurankulakNumbers = new string[168];
            string num = string.Empty;
            string firstletter = string.Empty;
            string secondletter = string.Empty;
            int sl = 0;
            int fl = 97;

            for (int i = 0; i < 168; i++)
            {
                if (i < 26)
                {
                    num = ((char)(i + 65)).ToString();
                }
                else
                {
                    firstletter = ((char)(fl)).ToString();
                    secondletter = ((char)(sl + 65)).ToString();
                    sl++;
                    num = firstletter + secondletter;
                    if (sl == 26)
                    {
                        fl++;
                        sl = 0;
                    }
                }
                DurankulakNumbers[i] = num;
            }

            return DurankulakNumbers;
        }
        static BigInteger FromDurankulakNumbers(string num, string[] numbers)
        {
            BigInteger numToDecimal = 0;
            List<string> duranNum = new List<string>();

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 'a' && num[i] < 'z')
                {
                    duranNum.Add(num[i].ToString() + num[i + 1].ToString());
                    i++;
                }
                else
                {
                    duranNum.Add(num[i].ToString());
                }
            }

            BigInteger power = 1;

            for (int i = 0; i < duranNum.Count - 1; i++)
            {
                power *= 168;
            }

            for (int i = 0; i < duranNum.Count; i++)
            {

                BigInteger hex = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == duranNum[i])
                    {

                        hex = (BigInteger)j;
                        break;
                    }
                }
                numToDecimal += (BigInteger)(power * hex);
                power /= 168;
            }

            return numToDecimal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _1.KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());

            string[] numbers = GenerateNumber();
            Console.WriteLine(ToKaspichanNumbers(number, numbers));
        }

        static string[] GenerateNumber ()
        {
            //Dictionary<int, string> kaspichanNumbers = new Dictionary<int, string>();
            string[] kaspichanNumbers = new string[256];
            string num = string.Empty;
            string firstletter = string.Empty;
            string secondletter = string.Empty;
            int sl = 0;
            int fl = 97;

            for (int i = 0; i < 256; i++)
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
                kaspichanNumbers[i] = num;
                //KaspichanNumbers.Add(i, "A");
            }

            return kaspichanNumbers;
        }
        static string ToKaspichanNumbers(ulong num, string[] numbers)
        {
            StringBuilder numToKaspichanNumbers1 = new StringBuilder();
            numToKaspichanNumbers1.Insert(1, " ");
            string numToKaspichanNumbers = string.Empty;
            ulong kas;
            if (num == 0)
            {
                return "A";
            }
            while (num > 0)
            {
                kas = num % 256;

                numToKaspichanNumbers = numbers[kas] + numToKaspichanNumbers;
                //numToKaspichanNumbers.Append(numbers[kas]);
                num /= 256;

            }
            
            return numToKaspichanNumbers.ToString();
        }
    }
}

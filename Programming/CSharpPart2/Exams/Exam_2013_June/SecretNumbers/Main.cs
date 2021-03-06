using System;
using System.Numerics;

class SecretNumbers
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        if (n < 0)
        {
            n *=-1;
        }
       
        string num = n.ToString();
        BigInteger reminder = 0;
        BigInteger productOdd = 0;
        BigInteger productEven = 0;
        BigInteger secretNum = 0;

        for (int position = 1; position <= num.Length; position++)
        {
            reminder = n % 10;
            n /= 10;

            if (position % 2 == 0)
            {
                productEven += reminder * reminder * position;
            }
            else
            {
                productOdd += reminder * position * position;
            }
        }

        secretNum = productOdd + productEven;
        Console.WriteLine(secretNum);
        BigInteger remainder = secretNum % 26;
        int count = 0;

        for (int i = 1; i <= 26; i++)
        {
            if (secretNum % 10 == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", num);
                break;
            }
            count++;
            BigInteger letter = remainder + i;

            if (letter > 26)
            {
                letter = 1;
                i = 1;
                remainder = 0;
            }
            Console.Write((char)(letter + 64));

            if (count == secretNum % 10)
            {
                break;
            }
        }
    }
}
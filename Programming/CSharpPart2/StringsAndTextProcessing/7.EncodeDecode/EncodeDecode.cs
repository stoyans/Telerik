/*Write a program that encodes and decodes a 
 * string using given encryption key (cipher). 
 * The key consists of a sequence of characters. 
 * The encoding/decoding is done by performing XOR (exclusive or) operation 
 * over the first letter of the string with the first of the key, 
 * the second – with the second, etc. 
 * When the last key character is reached, the next is the first.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.EncodeDecode
{
    class EncodeDecode
    {
        static string Message()
        {
            string message = "Message was sent!";
            Console.WriteLine("Orignal text: {0}", message);
            Console.WriteLine();
            return message;
        }

        static int[] Cipher()
        {
            Random generate = new Random();
            int[] cipher = new int[5];

            Console.Write("cipher: ");
            for (int i = 0; i < cipher.Length; i++)
            {
                cipher[i] = generate.Next(65, 91);
                Console.Write((char)cipher[i]);
            }

            return cipher;
        }

        static string Encode(string message, int[] cipher)
        {
            string encodedMessage = string.Empty;
            int j = 0;
            for (int i = 0; i < cipher.Length; i++)
            {
                int codedElement = message[j]^ cipher[i];
                //char symbol = (char)codedElement;
                encodedMessage += (char)codedElement;

                if (j == message.Length - 1)
                {
                    break;
                }
                if (i == cipher.Length - 1)
                {
                    i = -1;
                }
                j++;
            }

            Console.WriteLine();
            Console.Write("Encode/Decode message: ");
            for (int i = 0; i < encodedMessage.Length; i++)
            {
                Console.Write((encodedMessage[i]));
            }
            Console.WriteLine();

            return encodedMessage;
        }

        static void Main()
        {
            string message = Message();
            int[] cipher = Cipher();
            string encodedMessage = Encode(message, cipher);
            Encode(encodedMessage, cipher);
        }
    }
}

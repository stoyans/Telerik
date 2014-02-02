using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.EncodeDecode
{
    class EncodeDecode
    {
        static void Message()
        {
            //string message = Console.ReadLine();
            string message = @"BKOXHI\EQOGX[YSOFTWARE8";

            StringBuilder cipherlen = new StringBuilder();
            for (int i = message.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(message[i]))
                {
                    cipherlen.Append(message[i]);
                }
                else
                {
                    break;
                }
            }

            StringBuilder encodedMsg = new StringBuilder();

            for (int i = 0; i < message.Length - cipherlen.Length; i++)
            {
                int num;
                if (int.TryParse(message[i].ToString(), out num))
                {
                    encodedMsg.Append(new string(message[i + 1], num-1));
                }
                else
                {
                    encodedMsg.Append(message[i]);
                }
            }
            CipherAndMessage(encodedMsg.ToString(), cipherlen.ToString());
        }

        static void CipherAndMessage(string encodedMsg, string lenCipher)
        {
            StringBuilder cipher = new StringBuilder();
            StringBuilder message = new StringBuilder();
            StringBuilder len = new StringBuilder();
            for (int i = lenCipher.Length - 1; i >= 0; i--)
            {
                len.Append(lenCipher[i]);
            }
            //Array.Reverse(lenCipher);

            for (int i = 0; i < encodedMsg.Length; i++)
            {
                if (i < encodedMsg.Length - int.Parse(len.ToString()))
                {
                    message.Append(encodedMsg[i]);
                }
                else
                {
                    cipher.Append(encodedMsg[i]);
                }
                
            }

            Decode(cipher.ToString(), message.ToString());
        }        

        static void Decode(string cipher, string encodedMessage)
        {
            int j = 0;
            List<char> decodedMessage = new List<char>();

            if (encodedMessage.Length >= cipher.Length)
            {
                for (int i = 0; i < cipher.Length; i++)
                {
                    int decodedElement = encodedMessage[j] - 65 ^ cipher[i] - 65;
                    char symbol = (char)(decodedElement + 65);
                    decodedMessage.Add(symbol);

                    if (j == encodedMessage.Length - 1)
                    {
                        break;
                    }
                    if (i == cipher.Length - 1)
                    {
                        i = -1;
                    }
                    j++;
                }
            }
            else
            {
                for (int i = 0; i < encodedMessage.Length; i++)
                {
                    int decodedElement = encodedMessage[j] - 65 ^ cipher[i] - 65;
                    char symbol = (char)(decodedElement + 65);
                    decodedMessage.Add(symbol);

                    if (j == encodedMessage.Length - 1)
                    {
                        for (int k = 0; k < cipher.Length - decodedMessage.Count; k++)
                        {
                            decodedElement = decodedMessage[k] - 65 ^ cipher[i+k+1] - 65;
                            symbol = (char)(decodedElement + 65);
                            decodedMessage.RemoveAt(k);
                            decodedMessage.Insert(k, symbol);
                        }
                        //break;
                    }
                    if (i == cipher.Length - 1)
                    {
                        i = -1;
                    }
                    j++;

                }
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < decodedMessage.Count; i++)
            {
                result.Append(decodedMessage[i]);
                //Console.Write((char)(decodedMessage[i]));
            }
            Console.WriteLine(result);
        }

        static void Main()
        {
            Message();
        }
    }
}

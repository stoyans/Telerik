using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace _1.MultiverseCommunication
{
    class MultiverseCommunication
    {

        static string ReadInput()
        {
            string message = Console.ReadLine();
            return message;
        }

        static string EncodedMessage(string message)
        {
            StringBuilder codedMessage = new StringBuilder();
            StringBuilder inNumbers = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                codedMessage.Append(message[i]);
                if (codedMessage.Length == 3)
                {

                    switch (codedMessage.ToString())
                    {
                        case "CHU": inNumbers.Append(0);
                            break;
                        case "TEL": inNumbers.Append(1);
                            break;
                        case "OFT": inNumbers.Append(2);
                            break;
                        case "IVA": inNumbers.Append(3);
                            break;
                        case "EMY": inNumbers.Append(4);
                            break;
                        case "VNB": inNumbers.Append(5);
                            break;
                        case "POQ": inNumbers.Append(6);
                            break;
                        case "ERI": inNumbers.Append(7);
                            break;
                        case "CAD": inNumbers.Append(8);
                            break;
                        case "K-A": inNumbers.Append(9);
                            break;
                        case "IIA": inNumbers.Append('A');
                            break;
                        case "YLO": inNumbers.Append('B');
                            break;
                        case "PLA": inNumbers.Append('C');
                            break;
                        default:
                            break;
                    }
                    codedMessage.Clear();
                }
            }
            return inNumbers.ToString();

        }
        static ulong ToDecimalConvert(string codedMessage)
        {
            ulong numToDecimal = 0;
            ulong power = 1;

            for (int i = 0; i < codedMessage.Length - 1; i++)
            {
                power *= 13;
            }

            for (int i = 0; i < codedMessage.Length; i++)
            {
                ulong number;

                if (codedMessage[i] >= 'A' && codedMessage[i] <= 'C')
                {
                    switch ((char)codedMessage[i])
                    {
                        case 'A': number = 10;
                            numToDecimal += (ulong)(power * number);
                            break;
                        case 'B': number = 11;
                            numToDecimal += (ulong)(power * number);
                            break;
                        case 'C': number = 12;
                            numToDecimal += (ulong)(power * number);
                            break;
                    }
                }
                else
                {
                    number = (ulong)codedMessage[i] - 48;
                    numToDecimal += (ulong)(power * number);
                }
                power /= 13;
            }

            return numToDecimal;
        }

        static void Main()
        {
            string message = ReadInput();
            string codedMessage = EncodedMessage(message);
            ulong result = ToDecimalConvert(codedMessage);
            Console.WriteLine(result);

        }
    }
}

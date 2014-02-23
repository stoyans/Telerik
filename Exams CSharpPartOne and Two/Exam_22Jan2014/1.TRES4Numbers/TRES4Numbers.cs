using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TRES4Numbers
{
    class TRES4Numbers
    {
        static ulong ReadInput()
        {
            ulong message = ulong.Parse(Console.ReadLine());
            return message;
        }

        static string EncodedMessage(ulong num)
        {
            StringBuilder originalMessage = new StringBuilder();
            if (num == 0)
            {
                return "LON+";
            }
            while (num > 0)
            {
                ulong remain = num % 9;
                switch (remain)
                {
                    case 0: originalMessage.Insert(0, "LON+");
                        break;
                    case 1: originalMessage.Insert(0, "VK-");
                        break;
                    case 2: originalMessage.Insert(0, "*ACAD");
                        break;
                    case 3: originalMessage.Insert(0, "^MIM");
                        break;
                    case 4: originalMessage.Insert(0, "ERIK|");
                        break;
                    case 5: originalMessage.Insert(0, "SEY&");
                        break;
                    case 6: originalMessage.Insert(0, "EMY>>");
                        break;
                    case 7: originalMessage.Insert(0, "/TEL");
                        break;
                    case 8: originalMessage.Insert(0, "<<DON");
                        break;
                    default:
                        break;
                }

                num /= 9;
            }

            
            return originalMessage.ToString();
        }


        

        static void Main()
        {
            ulong message = ReadInput();
            Console.WriteLine(EncodedMessage(message));

        }
    }
}

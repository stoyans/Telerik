using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.VariableLengthCoding
{
    class VariableLengthCoding
    {
        static void Main()
        {
            string inputNumbers = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());
            string[] codedLetters = new string[lines];
            
            for (int i = 0; i < codedLetters.Length; i++)
			{
                codedLetters[i] = Console.ReadLine();
			}

            string[] nums = inputNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sequence = new StringBuilder();

            for (int i = 0; i < nums.Length; i++)
            {
                string binary = Convert.ToString(int.Parse(nums[i]), 2);
                binary = binary.PadLeft(8, '0');
                sequence.Append(binary);
            }

            Dictionary<int, char> codedSymbols = new Dictionary<int, char>();

            for (int i = 0; i < codedLetters.Length; i++)
            {
                char letter = codedLetters[i][0];
                int code = int.Parse(codedLetters[i].Substring(1));
                codedSymbols.Add(code, letter);
            }

            StringBuilder message = new StringBuilder();
            int ones = 0;
            List<int> toNums = new List<int>();

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '1')
                {
                    ones++;
                    if (i == sequence.Length - 1 && ones != 0)
                    {
                        toNums.Add(ones);
                    }
                    
                }
                else
                {
                    if (ones != 0)
                    {
                        toNums.Add(ones);
                    }
                    ones = 0;
                }   
            }

            StringBuilder resultText = new StringBuilder();

            for (int i = 0; i < toNums.Count; i++)
            {
                //Console.WriteLine(codedSymbols[toNums[i]]);
                if (codedSymbols.ContainsKey(toNums[i]))
                {
                    resultText.Append(codedSymbols[toNums[i]]); 
                }
                
            }
            Console.WriteLine(resultText);

        }
    }
}

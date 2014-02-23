using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MagicWords
{
    class MagicWords
    {

        static string[] Input()
        {
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 0; i < n; i++)
			{
                array[i] = Console.ReadLine();			 
			}

            return array;
        }

        static List<string> Reorder(string[] words)
        {
            List<string> listOfWords = new List<string>(words);

            for (int i = 0; i < listOfWords.Count; i++)
            {
                string currentWord = listOfWords[i];
                int position = (currentWord.Length % (words.Length + 1));
                listOfWords.Insert(position, currentWord);
                if (position > i)
                {
                    listOfWords.RemoveAt(listOfWords.IndexOf(currentWord));
                }
                else
                {
                    listOfWords.RemoveAt(listOfWords.LastIndexOf(currentWord));
                }
           }
            return listOfWords; 
        }

        static int Length(string[] words)
        {
            int len = words[0].Length;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > len)
                {
                    len = words[i].Length;

                }
                
            }
            return len;
        }

        static void Print(List<string> reorderedWords, int len)
        {
            int index = 0;
            StringBuilder result = new StringBuilder();
            while (index < len)
            {
                for (int i = 0; i < reorderedWords.Count; i++)
                {

                    if (index < reorderedWords[i].Length)
                    {
                        result.Append(reorderedWords[i][index]);

                    }
                }
                index++;
            }

            Console.WriteLine(result);
            
                 
        }

        static void Main()
        {
            string[] words = Input();
            List<string> reorderedWords = Reorder(words);
            int len = Length(words);
            Print(reorderedWords, len);

        }
    }
}

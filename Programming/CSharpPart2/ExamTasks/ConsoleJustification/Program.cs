using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ConsoleJustification
{
    class ConsoleJustification
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();
            //string text = string.Empty;

            //saving the input data
            for (int i = 0; i < N; i++)
            {
                text.Append(Console.ReadLine());
                text.Append('\n');
            }
            //string text = @"We happy few        we band
            //                of brothers for he who sheds
            //                his blood
            //                with
            //                me shall be my brother  dda dada";


            string[] splitText = text.ToString().Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> line = new List<string>();
            StringBuilder resultLine = new StringBuilder();
            List<string> resultext = new List<string>();

            int lenOfWords = 0;
            int numberOfWord = 0;
            int numberOfWhitespaes = 0;

            for (int j = 0; j < N; j++)
            {
                for (int i = numberOfWord; i < splitText.Length; i++)
                {

                    lenOfWords += splitText[i].Length;
                    line.Add(splitText[i]);

                    //checking if it is the last word of the input text and the length of all words on the current line + whitespaces < М
                    if (i == splitText.Length - 1 && (lenOfWords + numberOfWhitespaes) < M)
                    {
                        int[] whitespace = new int[numberOfWhitespaes];
                        int count = 0;
                        int countmaxwhitespaces = 0;
                        while (lenOfWords + numberOfWhitespaes + count <= M)
                        {
                            for (int w = 0; w < numberOfWhitespaes; w++)
                            {
                                if (lenOfWords + countmaxwhitespaces < M)
                                {
                                    whitespace[w]++;
                                    countmaxwhitespaces++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            count++;
                        }

                        for (int k = 0; k < line.Count; k++)
                        {
                            resultLine.Append(line[k]);
                            if (k < line.Count - 1)
                            {
                                resultLine.Append(new string(' ', whitespace[k]));
                            }
                        }

                        resultext.Add(resultLine.ToString());
                    }

                    //the algotithm below is the same as the one above just on a different condition here is missing (if i(current word) == splitText.Length - 1(last word))
                    else if (lenOfWords + numberOfWhitespaes >= M)
                    {
                        if (lenOfWords + numberOfWhitespaes > M)
                        {
                            numberOfWhitespaes--;
                            lenOfWords -= line[line.Count - 1].Length;
                            line.RemoveAt(line.Count - 1);
                            i--;

                        }
                        int[] whitespace = new int[numberOfWhitespaes];
                        int count = 0;
                        int countmaxwhitespaces = 0;
                        while (lenOfWords + numberOfWhitespaes + count <= M)
                        {
                            for (int w = 0; w < numberOfWhitespaes; w++)
                            {
                                if (lenOfWords + countmaxwhitespaces < M)
                                {
                                    whitespace[w]++;
                                    countmaxwhitespaces++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            count++;
                        }

                        for (int k = 0; k < line.Count; k++)
                        {
                            resultLine.Append(line[k]);
                            if (k < line.Count - 1)
                            {
                                resultLine.Append(new string(' ', whitespace[k]));
                            }
                        }

                        resultext.Add(resultLine.ToString());

                        numberOfWhitespaes = -1;
                        lenOfWords = 0;

                        line.Clear();
                        resultLine.Clear();


                    }
                    numberOfWhitespaes++;
                    numberOfWord++;

                }

            }

            foreach (var item in resultext)
            {
                Console.WriteLine(item);
            }

        }
    }
}

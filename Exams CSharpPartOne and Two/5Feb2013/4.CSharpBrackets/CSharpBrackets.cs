using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CSharpBrackets
{
    class CSharpBrackets
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] text = new string[N];
            string tab = Console.ReadLine();

            for (int i = 0; i < N; i++)
			{
                text[i] = Console.ReadLine();
			}

            int countOpenBracket = 0;
            int countCloseBracket = 0;

            StringBuilder line = new StringBuilder();
            StringBuilder bracket = new StringBuilder();

            List<string> printLine = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length == 0)
                {
                    continue;
                }
                if (text[i].IndexOf('{') == -1 && text[i].IndexOf('}') == -1)
                {

                    for (int j = 0; j < countOpenBracket - countCloseBracket; j++)
                    {
                        bracket.Append(tab);
                    }
                    line.Append(bracket.ToString());
                    line.Append(text[i].Trim());
                    printLine.Add(line.ToString());
                    line.Clear();
                    bracket.Clear();

                }
                else
                {
                    
                    for (int k = 0; k < text[i].Length; k++)
                    {
                        if (text[i][k] == '{')
                        {
                            for (int j = 0; j < countOpenBracket - countCloseBracket; j++)
                            {
                                bracket.Append(tab);
                            }
                            if (line.ToString().Length != 0)
                            {
                                line.Insert(0, bracket.ToString());
                                printLine.Add(line.ToString().Trim());
                                if (printLine.ToString()[printLine.ToString().LastIndexOf('.')+1] == ' ')
                                {
                                    printLine.RemoveAt(printLine.ToString().LastIndexOf('.')+1);
                                }
                                line.Clear();
                            }
                            printLine.Add(bracket.Append('{').ToString());
                            bracket.Clear();
                            countOpenBracket++;
                        }
                        else if (text[i][k] == '}')
                        {
                            countCloseBracket++;
                            for (int j = 0; j < countOpenBracket - countCloseBracket; j++)
                            {
                                bracket.Append(tab);
                            }
                            printLine.Add(bracket.Append('}').ToString());
                            bracket.Clear();
                        }
                        else
                        {
                            if (k == text[i].Length - 1)
                            {
                                continue;
                            }
                            line.Append(text[i][k]);
                            if (text[i][k + 1] == '}')
                            {
                                for (int j = 0; j < countOpenBracket - countCloseBracket; j++)
                                {
                                    bracket.Append(tab);
                                }
                                line.ToString().TrimStart();
                                line.Insert(0, bracket.ToString()).ToString();
                                printLine.Add(line.ToString());
                                line.Clear();
                                bracket.Clear();
 
                            }
                        }


                    }
                }
                
            }

            StringBuilder resultRow = new StringBuilder();
            foreach (var row in printLine)
            {
                string[] splitrow = row.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < splitrow.Length; i++)
                {
                    resultRow.Append(splitrow[i]);
                    if (i != splitrow.Length - 1)
                    {
                        resultRow.Append(' ');
                    }
                }
                Console.WriteLine(resultRow);
                resultRow.Clear();
                
            }

        }
    }
}

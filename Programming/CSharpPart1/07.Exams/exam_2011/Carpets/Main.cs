using System;
using System.Diagnostics;
using System.Threading;

namespace Carpets
{
    class Carpets
    {
        static void Main()
        {
            Stopwatch time = new Stopwatch ();
            time.Start();

            int N = int.Parse(Console.ReadLine());

            for (int row = 1; row <= N/2; row++)
            {
                for (int write = 1; write <= N; write++)
                {
                    if ((N / 2) % 2 == 0)
                    {
                        if ((row % 2 == 0 && write >= N / 2 + 1 - row && write <= N / 2 && write % 2 != 0) || (row % 2 != 0 && write >= N / 2 + 1 - row && write <= N / 2 && write % 2 == 0))
                        {
                            Console.Write('/');
                        }
                        else if ((row % 2 == 0 && write <= N / 2 + row && write >= N / 2 + 1 && write % 2 == 0) || (row % 2 != 0 && write <= N / 2 + row && write >= N / 2 + 1 && write % 2 != 0))
                        {
                            Console.Write('\\');
                        }

                        else if (write < N / 2 + 1 - row || write > N / 2 + row)
                        {
                            Console.Write('.');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    if ((N / 2) % 2 != 0)
                    {
                        if ((row % 2 == 0 && write >= N / 2 + 1 - row && write <= N / 2 && write % 2 == 0) || (row % 2 != 0 && write >= N / 2 + 1 - row && write <= N / 2 && write % 2 != 0))
                        {
                            Console.Write('/');
                        }
                        else if ((row % 2 == 0 && write <= N / 2 + row && write >= N / 2 + 1 && write % 2 != 0) || (row % 2 != 0 && write <= N / 2 + row && write >= N / 2 + 1 && write % 2 == 0))
                        {
                            Console.Write('\\');
                        }

                        else if (write < N / 2 + 1 - row || write > N / 2 + row)
                        {
                            Console.Write('.');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                      
                }
                Console.WriteLine();               
            }

            for (int row = 1; row <= N / 2; row++)
            {
                for (int write = 1; write <= N; write++)
                {
                    if ((N / 2) % 2 != 0)
                    {
                        if ((row % 2 == 0 && write >= row && write <= N / 2 && write % 2 == 0) || (row % 2 != 0 && write <= N/2 && write >= row && write % 2 != 0))
                        {
                            Console.Write('\\');
                        }
                        else if ((row % 2 == 0 && write <= N+ 1 - row && write >= N / 2 +1 && write % 2 != 0) || (row % 2 != 0 && write <= N + 1 - row  && write >= N / 2 +1 && write % 2 == 0))
                        {
                            Console.Write('/');
                        }

                        else if (write < row || write > N - row)
                        {
                            Console.Write('.');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    if ((N / 2) % 2 == 0)
                    {
                        if ((row % 2 == 0 && write >= row && write <= N / 2 && write % 2 == 0) || (row % 2 != 0 && write <= N / 2 && write >= row && write % 2 != 0))
                        {
                            Console.Write('\\');
                        }
                        else if ((row % 2 == 0 && write <= N + 1 - row && write >= N / 2 + 1 && write % 2 != 0) || (row % 2 != 0 && write <= N + 1 - row && write >= N / 2 + 1 && write % 2 == 0))
                        {
                            Console.Write('/');
                        }

                        else if (write < row || write > N - row)
                        {
                            Console.Write('.');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                }
                Console.WriteLine();
                time.Stop();
                
            }
            //Console.WriteLine(time.Elapsed);
        }
    }
}

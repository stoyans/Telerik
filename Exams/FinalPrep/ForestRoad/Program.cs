using System;

namespace ForestRoad
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[2 * N - 1, N];

            int currentRow = 0;
            int currentCol = 0;

            while (true)
            {
                matrix[currentRow, currentCol] = 1;

                currentRow++;
                if (currentRow < N)
                {
                    currentCol++;
                }
                else
                {
                    currentCol--;
                }
                if (currentRow == 2*N - 1)
                {
                    break;
                }
            }

            for (int row = 0; row < 2*N - 1; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (matrix[row,col] == 0)
                    {
                        Console.Write('.');
                    }
                    else if (matrix[row,col] == 1)
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

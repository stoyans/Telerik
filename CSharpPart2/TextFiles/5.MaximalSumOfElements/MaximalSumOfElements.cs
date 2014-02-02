/*Write a program that reads a text file containing a square matrix of numbers  * and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.  * The first line in the input file contains the size of matrix N.  * Each of the next N lines contain N numbers separated by space.  * The output should be a single number in a separate text file. Example:42 3 3 40 2 3 4			173 7 1 24 3 3 2*/

using System;
using System.Text;
using System.IO;

class MaximalSumOfElements
{

    static int[,] ReadDate()
    {
        const string filePath = @"..\..\matrix.txt";
        StreamReader readfile = new StreamReader(filePath);

        string readLine = readfile.ReadLine();
        int size = int.Parse(readLine);
        int[,] matrix = new int[size, size];

        using (readfile)
        {
            int row = 0;
            while ((readLine = readfile.ReadLine()) != null)
            {
                string[] valuesOnLine = readLine.Split(' ');

                if (valuesOnLine[0] != string.Empty)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = int.Parse(valuesOnLine[col]);
                    }
                    row++;
                }
            }
            readfile.Close();
        }

        return matrix;

    }

    static int FindMaxSum(int[,] matrix)
    {
        int bestSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        int currentSum = 0;

        for (int row = 0; row <= matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - 2; col++)
            {
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                }
                currentSum = 0;

                for (int currRow = row; currRow < row + 2; currRow++)
                {
                    for (int currcol = col; currcol < col + 2; currcol++)
                    {
                        currentSum += matrix[currRow, currcol];
                    }
                }
            }

        }
        Console.WriteLine("The answer was saved in result.txt");
        return bestSum;
    }

    static void FileWrite(int sum)
    {
        StreamWriter writeToFile = new StreamWriter("..\\..\\result.txt", false, Encoding.GetEncoding("windows-1251"));
        writeToFile.WriteLine("Best sum 2x2 is {0}.", sum);
        writeToFile.Dispose();
    }

    static void Main()
    {
        int maxSum = FindMaxSum(ReadDate());
        FileWrite(maxSum);
    }
}

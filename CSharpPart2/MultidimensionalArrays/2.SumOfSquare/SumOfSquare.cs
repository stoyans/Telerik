/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/

using System;
using System.Collections.Generic;

class SumOfSquare3x3
{
    static void Main()
    {
        Console.Write("The rows of the matrix: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("The cols of the matrix: ");
        int M = int.Parse(Console.ReadLine());
        Console.Write("enter the dimension of the square (2x2, 3x3, etc.): ");
        int square = int.Parse(Console.ReadLine());

        Random nums = new Random();

        int temp = Math.Min(N, M);
        //checks if the dimension is bigger than N or M. If so the square = Math.Min(N, M);
        if (square > temp)
        {
            square = temp;
        }

        int bestSum = int.MinValue;

        int[,] matrix = new int[N, M];
        //int[,] result = new int[square, square];

        //filling the matrix
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                matrix[row, col] = nums.Next(0, 10);
            }
        }
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        int currentSum = 0;

        for (int row = 0; row <= N - square; row++)
        {
            for (int col = 0; col <= M - square; col++)
            {
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                }
                currentSum = 0;

                for (int currRow = row; currRow < row + square; currRow++)
                {
                    for (int currcol = col; currcol < col + square; currcol++)
                    {
                        currentSum += matrix[currRow, currcol];
                        //result [currRow, currcol] = matrix[currRow, currcol];
                    }
                }
            }

        }

        if (currentSum > bestSum)
        {
            bestSum = currentSum;
        }
        Console.WriteLine("The maximal sum of {0}x{1} in the matrix is: {2}",square,square, bestSum);
        Console.WriteLine();
        /*for (int row = 0; row < square; row++)
        {
            for (int col = 0; col < square; col++)
            {
                Console.Write("{0, 4}", result[row, col]);
            }
            Console.WriteLine();
        }                    */

    }
}
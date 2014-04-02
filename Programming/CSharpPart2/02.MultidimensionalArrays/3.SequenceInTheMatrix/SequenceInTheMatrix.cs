/*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
 * Write a program that finds the longest sequence of equal strings in the matrix.*/

﻿using System;
using System.Collections.Generic;

class SequencesInMatrix
{
    static void Main()
    {
        List<string> listRow = new List<string>();
        List<string> listCol = new List<string>();
        List<string> listDiagonal = new List<string>();
        string[] bestLenRow = new string[0];
        string[] bestLenCol = new string[0];
        string[] bestLenDiagonal = new string[0];

        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        string[,] matrix = new string[N, M];
        string currentRow = null;
        string currentCol = null;
        string currentDiagonal = null;

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        listDiagonal.Add(matrix[0, 0]);
        listCol.Add(matrix[0, 0]);
        currentCol = matrix[0, 0];
        currentDiagonal = matrix[0, 0];

        //checking rows and diagonals
        for (int row = 0; row < N; row++)
        {
            listRow.Clear();
            listRow.Add(matrix[row, 0]);
            currentRow = matrix[row, 0];

            for (int col = 1; col < M; col++)
            {
                if (currentRow == matrix[row, col])
                {
                    listRow.Add(matrix[row, col]);
                }
                if (currentRow != matrix[row, col] || col == M - 1)
                {
                    if (listRow.Count > bestLenRow.Length)
                    {
                        bestLenRow = new string[listRow.Count];
                        listRow.CopyTo(bestLenRow);
                    }
                    listRow.Clear();
                    currentRow = matrix[row, col];
                    listRow.Add(matrix[row, col]);
                }

                if (currentDiagonal == matrix[row, col] && col == row)
                {
                    listDiagonal.Add(matrix[row, col]);
                }
                if (col == row && currentDiagonal != matrix[row, col])
                {
                    if (listDiagonal.Count > bestLenDiagonal.Length)
                    {
                        bestLenDiagonal = new string[listDiagonal.Count];
                        listDiagonal.CopyTo(bestLenDiagonal);
                    }
                    listDiagonal.Clear();
                    currentDiagonal = matrix[row, col];
                    listDiagonal.Add(matrix[row, col]);
                }

            }
        }

        //checking longest columns
        for (int col = 0; col < M; col++)
        {
            listCol.Clear();
            listCol.Add(matrix[0, col]);
            currentCol = matrix[0, col];

            for (int row = 1; row < N; row++)
            {
                if (currentCol == matrix[row, col])
                {
                    listCol.Add(matrix[row, col]);
                }
                if (currentCol != matrix[row, col] || row == N - 1)
                {
                    if (listCol.Count > bestLenCol.Length)
                    {
                        bestLenCol = new string[listCol.Count];
                        listCol.CopyTo(bestLenCol);
                    }
                    listCol.Clear();
                    currentCol = matrix[row, col];
                    listCol.Add(matrix[row, col]);
                }
            }
        }

        if (listDiagonal.Count > bestLenDiagonal.Length)
        {
            bestLenDiagonal = new string[listDiagonal.Count];
            listDiagonal.CopyTo(bestLenDiagonal);
        }

        int result = Math.Max(Math.Max(bestLenCol.Length, bestLenRow.Length), bestLenDiagonal.Length);
        Console.WriteLine();
        if (result == bestLenDiagonal.Length)
        {
            Console.WriteLine(string.Join(" ", bestLenDiagonal));
        }
        else if (result == bestLenCol.Length)
        {
            Console.WriteLine(string.Join(" ", bestLenCol));
        }
        else if (result == bestLenRow.Length)
        {
            Console.WriteLine(string.Join(" ", bestLenRow));
        }
    }
}
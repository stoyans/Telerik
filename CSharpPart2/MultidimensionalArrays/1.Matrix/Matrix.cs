/*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16   etc */     

using System;
using System.Collections.Generic;

class Matrix
{
    static void Main()
    {
        Console.Write("enter the dimension of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("enter the version of the array you want to be printed (a, b, c or d): ");
        char choice = char.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        switch (choice)
        {
            case 'a': versionA(n, matrix);
                break;
            case 'b': versionB(n, matrix);
                break;
            case 'c': versionC(n, matrix);
                break;
            case 'd': versionD(n, matrix);
                break;
            default: Console.WriteLine("wrong choice!");
                break;
        }
    }

    static void versionA(int n, int[,] matrix, int counter = 1)
    {
        //fill the matrix
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = counter;
                counter++;
            }

        }
        //print the matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }

    }
    static void versionB(int n, int[,] matrix, int counter = 1)
    {
        //fill the matrix
        for (int col = 0; col < n; col++)
        {
            if (col % 2 != 0)
            {
                counter += n;
                for (int row = 0; row < n; row++)
                {
                    counter--;
                    matrix[row, col] = counter;
                }
            }
            else
            {
                if (col > 0)
                {
                    counter += n;
                }
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
        }
        //print the matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
    static void versionC(int n, int[,] matrix)
    {
        int row = 0;
        int col = 0;
        string direction = "diagonal";
        int maxRotations = n * n;
        bool secondPart = false;

        for (int i = 1; i <= maxRotations; i++)
        {
            //filling the first part of the matrix
            if (secondPart == false)
            {
                matrix[row, col] = i;

                if (direction == "diagonal")
                {   
                    //find the numbers in all diagonals
                    int temp = row;
                    for (int j = 0; j < temp; j++)
                    {
                        i++;
                        col++;
                        row--;
                        matrix[row, col] = i;
                    }
                    direction = "up";
                    col -= col;
                    row = temp;
                }
                //moving up until row = n - 1
                if (direction == "up" && row < n - 1)
                {
                    row++;
                    direction = "diagonal";
                }
                else
                {
                    //when the above condition is false - we start with the second part of the matrix
                    secondPart = true;
                    col = 1;
					direction = "diagonal";
                }
            }
            else
            {
                matrix[row, col] = i;
                //condition to break the loop when we reach top-right corner
				if (row == n-1 && col == n-1) 
				{
					break;	
				}
				
				if (direction == "diagonal") 
				{
					int temp = col;
					for (int j = 0; j < n - temp -1; j++) 
					{
						i++;
						col++;
						row--;
						matrix[row, col] = i;
					}
					direction = "up";
					col = temp;
					row = n-1;
				}
				if (direction == "up" && col < n) 
				{
					col++;
					direction = "diagonal";
				}
            }

        }
        for (int r = n-1; r >= 0; r--)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0,4}", matrix[r, c]);
            }
            Console.WriteLine();
        }

    }
    static void versionD(int n, int[,] matrix)
    {
        int row = 0;
        int col = 0;
        string direction = "right";
        int maxRotations = n * n;

        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }

            if (direction == "up" && row < 0 || matrix[row, col] != 0)
            {
                direction = "right";
                row++;
                col++;
            }

            matrix[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        // Display Matrix
        for (int c = 0; c < n; c++)
        {
            for (int r = 0; r < n; r++)
            {
                Console.Write("{0,4}", matrix[r, c]);
            }
            Console.WriteLine();
        }
    }
}

namespace OperationMatrix
{
    using System;

    public class Matrix
    {
        private const int Directions = 8;
        private int dimension;
        private int[,] matrix;

        public Matrix(int dimension)
        {
            this.Dimension = dimension;
            this.matrix = new int[this.Dimension, this.Dimension];
        }

        private int Dimension
        {
            get
            {
                return this.dimension;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("You haven't entered a correct positive number!\n Value must be {0:100}");
                }

                this.dimension = value;
            }
        }

        public void FillMatrix()
        {
            int step = this.Dimension, k = 1, i = 0, j = 0, dx = 1, dy = 1;

            while (true)
            {

                this.matrix[i, j] = k;
                if (!this.CheckDirection(this.matrix, i, j))
                {
                    break;
                }

                if (i + dx >= this.Dimension || i + dx < 0 || j + dy >= this.Dimension || j + dy < 0 || this.matrix[i + dx, j + dy] != 0)
                {
                    while ((i + dx >= this.Dimension || i + dx < 0 || j + dy >= this.Dimension || j + dy < 0 || this.matrix[i + dx, j + dy] != 0))
                    {
                        this.Change(ref dx, ref dy);
                    }
                }

                i += dx;
                j += dy;
                k++;
            }

            this.FindEmptyCell(this.matrix, out i, out j);
        }

        public void PrintMatrix()
        {
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", this.matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private void Change(ref int dx, ref int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;

            for (int count = 0; count < Directions; count++)
            {
                if (dirX[count] == dx && dirY[count] == dy)
                {
                    cd = count;
                    break;
                }
            }

            if (cd == 7)
            {
                dx = dirX[0];
                dy = dirY[0];
            }
            else
            {
                dx = dirX[cd + 1];
                dy = dirY[cd + 1];
            } 
        }

        private bool CheckDirection(int[,] matrix, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < Directions; i++)
            {
                if (y + dirY[i] >= matrix.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }

                if (x + dirX[i] >= matrix.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                } 
            }

            for (int i = 0; i < Directions; i++)
            {
                if (matrix[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void FindEmptyCell(int[,] matrix, out int row, out int col)
        {
            row = 0;
            col = 0;

            for (int indexRow = 0; indexRow < matrix.GetLength(0); indexRow++)
            {
                for (int indexCol = 0; indexCol < matrix.GetLength(0); indexCol++)
                {
                    if (matrix[indexRow, indexCol] == 0)
                    {
                        row = indexRow;
                        col = indexCol;
                        return;
                    }
                }
            }
        }
    }
}
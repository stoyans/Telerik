using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_10.Matrix
{
    public class Matrix<T> where T : IComparable, IFormattable
    {
        private int row;
        private int col;
        private T[,] matrix;


        public Matrix(int row, int col, T[,] matrix)
        {
            this.Row = row;
            this.Col = col;
            this.matrix = matrix;
        }
        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.matrix = new T[row, col];
        }

        public Matrix()  : this(0, 0, new T[0, 0])
        {

        }

        public int Row
        {
            get
            {
                return this.row;
            }
            set
            {
                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }
            set
            {
                this.col = value;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || col < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return matrix[row, col];
            }
            set
            {
                if (row < 0 || col < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                matrix[row, col] = value;
            }

        }

        public void Print()
        {
            for (int rows = 0; rows < Row; rows++)
            {
                Console.WriteLine();
                for (int col = 0; col < Col; col++)
                {
                    Console.Write("{0,4}", this.matrix[rows, col]);
                }
            }
            Console.WriteLine();
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.row != matrix2.row || matrix1.col != matrix2.col)
            {
                throw new ArgumentException("Matrixes must be the same size!");
            }
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.Row, matrix2.Col);
            for (int i = 0; i < matrix1.row; i++)
            {
                for (int j = 0; j < matrix2.col; j++)
                {
                    resultMatrix[i, j] = (dynamic)matrix1[i, j] + (dynamic)matrix2[i, j];
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.row != matrix2.row || matrix1.col != matrix2.col)
            {
                throw new ArgumentException("Matrixes must be the same size!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(matrix1.row, matrix2.col);
            for (int i = 0; i < matrix1.row; i++)
            {
                for (int j = 0; j < matrix2.col; j++)
                {
                    resultMatrix[i, j] = (dynamic)matrix1[i, j] - (dynamic)matrix2[i, j];
                }
            }

            return resultMatrix;
        }
        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.row, matrix2.col);
            T result = (dynamic)0;
            int j;
            //collects the result of the multiplication
            List<T> nums = new List<T>();

            for (int k = 0; k < matrix1.row; k++)
            {
                for (int i = 0; i < matrix1.row; i++)
                {
                    result = (dynamic)0;
                    for (j = 0; j < matrix2.col; j++)
                    {
                        result += (dynamic)matrix1[i, j] * (dynamic)matrix2[j, k];
                       
                    }
                    nums.Add(result);
                   
                }
            }
            //filling the matrix with the results
            int indexes = 0;
            for (int i = 0; i < matrix1.row; i++)
            {
                for (j = 0; j < matrix2.col; j++)
                {
                    resultMatrix[i, j] = nums[indexes];
                    indexes++;
                }
            }
            

            return resultMatrix;
        }
        public static Boolean operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        return false;
                        break;
                    }
                }
            }
            return true;
        }

        public static Boolean operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        return false;
                        break;
                    }
                }
            }
            return true;
        }

    }
}


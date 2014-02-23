using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_10.Matrix
{
    class Program
    {
        static void Main()
        {
            Matrix<decimal> matrix = new Matrix<decimal>(3, 3, new decimal[,] { { 2, 2, 1 }, { -1, 4, 8 }, { 3, 4, 0 } });
            Matrix<decimal> matrix2 = new Matrix<decimal>(3, 3, new decimal[,] { { 2, 2, 1 }, { -1, 4, 8 }, { 3, 4, 0 } });
            matrix.Print();

            (matrix + matrix2).Print();
            (matrix - matrix2).Print();
            (matrix * matrix2).Print();
            if (matrix)
            {
                Console.WriteLine("There is no 0 in the matrix");
            }
            else
            {
                Console.WriteLine("There is 0 in the matrix cells");
            }
        }
    }
}

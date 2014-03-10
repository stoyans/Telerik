using System;
using System.Text;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[32, 32];
        int countRow = 0;
        bool isOne = false;
        int countZeros = 0;

        for (int row = 0; row < 32; row++)
        {

            long num = long.Parse(Console.ReadLine());
            if (num == -1)
            {
                break;
            }
            string numToString = Convert.ToString(num, 2).PadLeft(32, '0');
            countRow++;
            for (int col = 0; col < 32; col++)
            {
                matrix[row, col] = int.Parse(numToString[col].ToString());
            }
        }
        int[,] result = new int[countRow, 32];

        for (int row = 0; row < countRow; row++)
        {
            countZeros = 0;
            isOne = false;
            for (int col = 0; col < 32; col++)
            {
                if (matrix[row, col] == 1)
                {
                    if (countZeros != 0)
                    {
                        isOne = false;
                    }
                    else
                    {
                        matrix[row, col] = 0;
                        isOne = true;
                    }

                }
                else if (isOne == true && matrix[row, col] == 0)
                {
                    result[row, col] = 1;
                    countZeros++;
                }

            }
            if (isOne == true)
            {

                for (int col = 0; col < 32; col++)
                {
                    result[row, col] = 0;
                }

            }
        }

        for (int row = 0; row < countRow; row++)
        {
            StringBuilder sb = new StringBuilder();
            for (int col = 0; col < 32; col++)
            {
                sb.Append(result[row, col]);
                //Console.Write("{0, 2}", result[row, col]);
            }
            int num = Convert.ToInt32(sb.ToString(), 2);

            Console.WriteLine(num);
        }

    }
}


using System;
using System.Text;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        string direction = "south";
        int rows = 0;
        int cols = 7;
        int path = 0;
        int turns = 0;
        bool final = false;

        bool isWest = false;
        bool isNorth = false;
        bool isSouth = false;

        for (int row = 0; row < 8; row++)
        {

            byte num = byte.Parse(Console.ReadLine());
            string numToString = Convert.ToString(num, 2).PadLeft(8, '0');

            for (int col = 0; col < 8; col++)
            {
                matrix[row, col] = int.Parse(numToString[col].ToString());
            }
        }

        for (int i = 0; i < 64; i++)
        {
            int countS = 0;
            int countW = 0;
            int countN = 0;

            if (direction == "south" && matrix[rows, cols] == 1)
            {
                direction = "west";
                turns++;
                cols--;
                rows--;
                isSouth = true;
            }
            else if (direction == "south" && matrix[rows, cols] == 0)
            {
                countS++;
                if (rows == 7)
                {
                    if (cols == 0)
                    {
                        path += countS;
                        final = true;
                        break;
                    }
                    else
                    {
                        direction = "west";
                        cols--;
                    }
                }
                else
                {
                    rows++;
                }
                
            }
            if (direction == "west" && matrix[rows, cols] == 1)
            {
                isWest = true;
                rows--;
                cols++;
                direction = "north";
                turns++;
                if (isNorth == true || isSouth == true)
                {
                    break;
                }
            }
            else if (direction == "west" && matrix[rows, cols] == 0)
            {
                countW++;
                if (cols == 0 && isWest == true)
                {
                    rows++;
                    direction = "south";
                    turns++;
                    isWest = false;
                }
                else if (cols == 0 && isWest == false)
                {
                    rows--;
                    direction = "north";
                    turns++;
                }
                else
                {
                    cols--;
                    isSouth = false;
                    if (cols == 0 && rows ==7)
                    {
                        final = true;
                        path += countW;
                        break;
                    }
                }
                
            }
            if (direction == "north" && matrix[rows, cols] == 1)
            {
                cols--;
                rows++;
                direction = "west";
                turns++;
            }
            else if (direction == "north" && matrix[rows, cols] == 0)
            {
                countN++;
                if (rows == 0)
                {
                    cols--;
                    direction = "west";
                    turns++;
                    isNorth = true;
                }
                else
                {
                    rows--;
                }
                
            }



            /*if (direction == "south" && countS == 0)
            {
                path = countS;
                break;
            }
            if (direction == "north" && countN == 0)
            {
                path = countN;
                break;
            }*/

            path += (countN + countS + countW);
            
        }

        if (final == true)
        {
            Console.WriteLine("{0} {1}", path, turns);
        }
        else
        {
            Console.WriteLine("No {0}",path);
        }
    }
}


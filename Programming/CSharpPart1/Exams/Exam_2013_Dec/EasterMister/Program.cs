using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int height = 2 * n;
        int widthEgg = 3 * n - 1;
        int widthDraw = 3 * n + 1;
        int top = n - 1;
        int bottom = n - 1;
        int temp = (widthDraw - 1) / 2 - top / 2;
        int temp1 = (widthDraw - 1) / 2 + top / 2;
        

        for (int row = 1; row <= height/2; row++)
        {
            bool isIn = false;
            for (int col = 1; col <= widthDraw; col++)
            {
                if (row == 1)
                {
                    isIn = true;
                    if ((col > temp && col <= temp1+1))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }      
                }
                
                if (row > 1 && row < height / 2 )
                {
                    isIn = true;
                    if (col == temp +3 - 2*row || col == temp1 + 2*row -1 )
                    {
                        Console.Write('*');
                    }
                    else if ((col == 2 || col == widthDraw-1) && (row < height / 2 && row > height/4+1))
                    {
                        Console.Write('*');
                    }
                    else 
                    {
                        Console.Write('.');
                    }
                }
            }
            if (isIn == true)
            {
                Console.WriteLine();
            }
           
        }

        for (int row = 1; row <= 2; row++)
        {
            for (int col = 1; col <= widthDraw; col++)
            {
                if (col == 2 || col == widthDraw - 1)
                {
                    Console.Write('*');
                }
                else if (row == 1 && (col > 2 && col < widthDraw-1 && col % 2 == 0 ))
                {
                    Console.Write('#');
                }
                else if (row == 2 && (col > 2 && col < widthDraw -1 && col % 2 != 0 ))
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write('.');
                }

            }
            Console.WriteLine();
        }

        for (int row = 1; row <= height / 2 - 1 - height / 4-1; row++)
        {
            for (int col = 1; col <= widthDraw; col++)
            {
                if ((row < height / 2 - 1 - height / 4) && (col == 2 || col == widthDraw - 1))
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }

        for (int row = 1; row <= n-1 - (height / 2 - 1 - height / 4); row++)
        {
            for (int col = 1; col <= widthDraw; col++)
            {
                if (col == 2 * row || col == widthDraw - 2*row +1 )
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
        for (int col = 1; col <= widthDraw; col++)
        {
            if (col <= temp1+1 && col > temp)
            {
                Console.Write('*');
            }
            else
            {
                Console.Write('.');
            }
        }
    }
}


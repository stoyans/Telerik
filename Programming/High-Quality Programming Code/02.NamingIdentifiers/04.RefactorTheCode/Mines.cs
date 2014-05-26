namespace GameMines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mines
    {
        public static void Main()
        {
            string command = string.Empty;
            char[,] field = CreateField();
            char[,] bombs = SetBombs();
            int pointsCounter = 0;
            bool explosion = false;
            List<Player> champions = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isGameOn = true;
            const int MAX = 35;
            bool isMaxResult = false;

            do
            {
                if (isGameOn)
                {
                    Console.WriteLine("Let's play \"Mines\". Test your luck to find the boxes without mines" +
                    "\nCommands:\n'top' -> Display ranking \n'restart' -> Starts a new game \n'exit' -> Exit the game!");
                    DrawField(field);
                    isGameOn = false;
                }

                Console.Write("Give position for Row and Column : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                        row < field.GetLength(0) && column < field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Ranking(champions);
                        break;
                    case "restart":
                        field = CreateField();
                        bombs = SetBombs();
                        DrawField(field);
                        explosion = false;
                        isGameOn = false;
                        break;
                    case "exit":
                        Console.WriteLine("You left the game!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                NewTurn(field, bombs, row, column);
                                pointsCounter++;
                            }

                            if (MAX == pointsCounter)
                            {
                                isMaxResult = true;
                            }
                            else
                            {
                                DrawField(field);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid Command!\n");
                        break;
                }

                if (explosion)
                {
                    DrawField(bombs);
                    Console.Write("\nBoooom! Game over!\n{0} points. " + "\nEnter your Nickname: ", pointsCounter);
                    string playerName = Console.ReadLine();
                    Player playerPoints = new Player(playerName, pointsCounter);
                    if (champions.Count < 5)
                    {
                        champions.Add(playerPoints);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < playerPoints.Points)
                            {
                                champions.Insert(i, playerPoints);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    Ranking(champions);

                    field = CreateField();
                    bombs = SetBombs();
                    pointsCounter = 0;
                    explosion = false;
                    isGameOn = true;
                }

                if (isMaxResult)
                {
                    Console.WriteLine("\nCongratulations! You opened 35 cells!");
                    DrawField(bombs);
                    Console.WriteLine("Enter your nickname: ");
                    string name = Console.ReadLine();
                    Player player = new Player(name, pointsCounter);
                    champions.Add(player);
                    Ranking(champions);
                    field = CreateField();
                    bombs = SetBombs();
                    pointsCounter = 0;
                    isMaxResult = false;
                    isGameOn = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Good bye");
            Console.Read();
        }

        private static void Ranking(List<Player> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ranking is empty!\n");
            }
        }

        private static void NewTurn(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsNumber = GetPoints(bombs, row, col);
            bombs[row, col] = bombsNumber;
            field[row, col] = bombsNumber;
        }

        private static void DrawField(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardColums = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardColums; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] SetBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] playGround = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playGround[i, j] = '-';
                }
            }

            List<int> bombs = new List<int>();
            while (bombs.Count < 15)
            {
                Random random = new Random();
                int position = random.Next(50);
                if (!bombs.Contains(position))
                {
                    bombs.Add(position);
                }
            }

            foreach (int i2 in bombs)
            {
                int col = i2 / cols;
                int row = i2 % cols;
                if (row == 0 && i2 != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                playGround[col, row - 1] = '*';
            }

            return playGround;
        }

        private static char GetPoints(char[,] field, int indexRow, int indexCol)
        {
            int points = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (indexRow - 1 >= 0)
            {
                if (field[indexRow - 1, indexCol] == '*')
                {
                    points++;
                }
            }

            if (indexRow + 1 < rows)
            {
                if (field[indexRow + 1, indexCol] == '*')
                {
                    points++;
                }
            }

            if (indexCol - 1 >= 0)
            {
                if (field[indexRow, indexCol - 1] == '*')
                {
                    points++;
                }
            }

            if (indexCol + 1 < cols)
            {
                if (field[indexRow, indexCol + 1] == '*')
                {
                    points++;
                }
            }

            if ((indexRow - 1 >= 0) && (indexCol - 1 >= 0))
            {
                if (field[indexRow - 1, indexCol - 1] == '*')
                {
                    points++;
                }
            }

            if ((indexRow - 1 >= 0) && (indexCol + 1 < cols))
            {
                if (field[indexRow - 1, indexCol + 1] == '*')
                {
                    points++;
                }
            }

            if ((indexRow + 1 < rows) && (indexCol - 1 >= 0))
            {
                if (field[indexRow + 1, indexCol - 1] == '*')
                {
                    points++;
                }
            }

            if ((indexRow + 1 < rows) && (indexCol + 1 < cols))
            {
                if (field[indexRow + 1, indexCol + 1] == '*')
                {
                    points++;
                }
            }

            return char.Parse(points.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameMines
{
    public class Mines
    {
        public class Player
        {
            private string name;
            private int points;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Points
            {
                get { return points; }
                set { points = value; }
            }

            public Player() { }

            public Player(string name, int points)
            {
                this.Name = name;
                this.Points = points;
            }
        }

        static void Main(string[] arguments)
        {
            string command = string.Empty;
            char[,] field = CreateField();
            char[,] bombs = SetBombs();
            int pointsCounter = 0;
            bool explosion = false;
            List<Player> champions = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool flag = true;
            const int MAX = 35;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    dumpp(field);
                    flag = false;
                }
                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1))
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
                        dumpp(field);
                        explosion = false;
                        flag = false;
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
                                flag2 = true;
                            }
                            else
                            {
                                dumpp(field);
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
                    dumpp(bombs);
                    Console.Write("\nBoooom! Game over!\n{0} points. " +
                        "\nEnter your Nickname: ", pointsCounter);
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
                    flag = true;
                }
                if (flag2)
                {
                    Console.WriteLine("\nCongratulations! You opened 35 cells!");
                    dumpp(bombs);
                    Console.WriteLine("Enter your nickname: ");
                    string name = Console.ReadLine();
                    Player player = new Player(name, pointsCounter);
                    champions.Add(player);
                    Ranking(champions);
                    field = CreateField();
                    bombs = SetBombs();
                    pointsCounter = 0;
                    flag2 = false;
                    flag = true;
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

        private static void dumpp(char[,] board)
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

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int col = (i2 / cols);
                int row = (i2 % cols);
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

        private static void smetki(char[,] playGround)
        {
            int col = playGround.GetLength(0);
            int row = playGround.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (playGround[i, j] != '*')
                    {
                        char kolkoo = GetPoints(playGround, i, j);
                        playGround[i, j] = kolkoo;
                    }
                }
            }
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

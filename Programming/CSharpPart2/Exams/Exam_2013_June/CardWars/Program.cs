using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int currScoreA = 0;
        int currScoreB = 0;
        int countFirstPlayer = 0;
        int countSecondPlayer = 0;
        bool winGameA = false;
        bool winGameB = false;
        bool bothX = false;
        int allPointsGameA = 0;
        int allPointsGameB = 0;

        for (int i = 0; i < n; i++)
        {
            countFirstPlayer = 0;
            countSecondPlayer = 0;
            winGameA = false;
            winGameB = false;

            string cardPlayerA1 = Console.ReadLine();
            if (cardPlayerA1 == "X")
            {
                winGameA = true;
            }
            else if (cardPlayerA1 == "Z")
            {
                allPointsGameA *= 2;
            }
            else if (cardPlayerA1 == "Y")
            {
                allPointsGameA -= 200;
            }
            countFirstPlayer += cards(cardPlayerA1, countFirstPlayer);

            string cardPlayerA2 = Console.ReadLine();
            if (cardPlayerA2 == "X")
            {
                winGameA = true;
            }
            else if (cardPlayerA2 == "Z")
            {
                allPointsGameA *= 2;
            }
            else if (cardPlayerA2 == "Y")
            {
                allPointsGameA -= 200;
            }
            countFirstPlayer += cards(cardPlayerA2, countFirstPlayer);

            string cardPlayerA3 = Console.ReadLine();
            if (cardPlayerA3 == "X")
            {
                winGameA = true;
            }
            else if (cardPlayerA3 == "Z")
            {
                allPointsGameA *= 2;
            }
            else if (cardPlayerA3 == "Y")
            {
                allPointsGameA -= 200;
            }
            countFirstPlayer += cards(cardPlayerA3, countFirstPlayer);

            string cardPlayerB1 = Console.ReadLine();
            if (cardPlayerB1 == "X")
            {
                winGameB = true;
            }
            else if (cardPlayerB1 == "Z")
            {
                allPointsGameB *= 2;
            }
            else if (cardPlayerB1 == "Y")
            {
                allPointsGameB -= 200;
            }
            countSecondPlayer += cards(cardPlayerB1, countSecondPlayer);

            string cardPlayerB2 = Console.ReadLine();
            if (cardPlayerB2 == "X")
            {
                winGameB = true;
            }
            else if (cardPlayerB2 == "Z")
            {
                allPointsGameB *= 2;
            }
            else if (cardPlayerB2 == "Y")
            {
                allPointsGameB -= 200;
            }
            countSecondPlayer += cards(cardPlayerB2, countSecondPlayer);

            string cardPlayerB3 = Console.ReadLine();
            if (cardPlayerB3 == "X")
            {
                winGameB = true;
            }
            else if (cardPlayerB3 == "Z")
            {
                allPointsGameB *= 2;
            }
            else if (cardPlayerB3 == "Y")
            {
                allPointsGameB -= 200;
            }
            countSecondPlayer += cards(cardPlayerB3, countSecondPlayer);

            if (winGameA == true && winGameB == true)
            {
                countFirstPlayer += 50;
                allPointsGameA += countFirstPlayer;
                countSecondPlayer += 50;
                allPointsGameB += countSecondPlayer;
                continue;
            }
            else if (winGameA == true && winGameB == false)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                break;
            }
            else if (winGameA == false && winGameB == true)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                break;
            }
            if ((winGameA == false && winGameB == false))
            {
                if (countFirstPlayer > countSecondPlayer)
                {
                    allPointsGameA += countFirstPlayer;
                    currScoreA++;
                    //countSecondPlayer -= countSecondPlayer;
                }
                else if (countSecondPlayer > countFirstPlayer)
                {
                    currScoreB++;
                    allPointsGameB += countSecondPlayer;
                    //countFirstPlayer -= countFirstPlayer;
                }
                else if (countSecondPlayer == countFirstPlayer)
                {
                    countSecondPlayer -= countSecondPlayer;
                    countFirstPlayer -= countFirstPlayer;
                    allPointsGameA += countFirstPlayer;
                    allPointsGameB += countSecondPlayer;
                }
            }

        }
        if (currScoreA > currScoreB && winGameA == false && winGameB == false)
        {
            //currScoreA++;
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", allPointsGameA);
            Console.WriteLine("Games won: {0}", currScoreA);
        }
        else if (currScoreA < currScoreB && winGameA == false && winGameB == false)
        {
            //currScoreB++;
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", allPointsGameB);
            Console.WriteLine("Games won: {0}", currScoreB);
        }
        else if (currScoreA == currScoreB && winGameA == false && winGameB == false)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", allPointsGameA);
        }


    }

    static int cards(string cardInput, int score)
    {
        switch (cardInput)
        {
            case "2": return 10;
            //break;
            case "3": return 9;
            //break;
            case "4": return 8;
            //break;
            case "5": return 7;
            // break;
            case "6": return 6;
            //break;
            case "7": return 5;
            // break;
            case "8": return 4;
            //break;
            case "9": return 3;
            // break;
            case "10": return 2;
            // break;
            case "A": return 1;
            //break;
            case "J": return 11;
            // break;
            case "Q": return 12;
            // break;
            case "K": return 13;
            //break;
            default: return 0;
            // break;
        }
    }
}


using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] boardpositions = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int startingPlayer = flipacoin();
            if (startingPlayer == 1) 
            {
                Console.Write("Player 1 Starts: ");
            }
            else
            {
                Console.Write("Player 2 Starts: ");
            }
            startgame(startingPlayer);
            string input = null;
            while (input != "exit")
            {
                Console.Write("Player {0}: ", startingPlayer);
                input = Console.ReadLine();
                int pos;
                if (int.TryParse(input, out pos))
                {
                    manipulateboard(boardpositions, pos, startingPlayer);
                    if(startingPlayer == 1)
                    {
                        startingPlayer = 2;
                    }
                    else
                    {
                        startingPlayer = 1;
                    }
                }
                else if (input == "exit")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for playing");
                }
                else
                {
                    Console.WriteLine("Please enter an integer from 1-9");
                }
            }


        }
        static void startgame(int startingplayer)
        {
            string[] boardpositions = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            redrawboard(boardpositions);
        }
        static void manipulateboard(string[] boardpositions, int pos, int startingplayer)
        {
            if(startingplayer == 1)
            {
                boardpositions[pos-1] = "X";
            }
            else
            {
                boardpositions[pos-1] = "O";
            }
            redrawboard(boardpositions);
        }
        static void redrawboard(string[] boardpositions)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", boardpositions[0], boardpositions[1], boardpositions[2]);
            Console.WriteLine("   |   |   ");
            Console.WriteLine("-------------");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", boardpositions[3], boardpositions[4], boardpositions[5]);
            Console.WriteLine("   |   |   ");
            Console.WriteLine("-------------");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", boardpositions[6], boardpositions[7], boardpositions[8]);
            Console.WriteLine("   |   |   ");

        }
        static int flipacoin()
        {
            Random rnd = new Random();
            int coinflip = rnd.Next(1,3);
            Console.WriteLine("Coin flip is: {0}", coinflip);
            return coinflip;

        }
    }
}

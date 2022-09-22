using System;
using System.Collections.Generic;
namespace Unit01
{
    class Program
    {
        static void Main(string[] args)
        {
            /// tic tac toe - Jacob Bunker 
            Console.WriteLine("how big of a board do you want? ");
            int BoardSize = int.Parse(Console.ReadLine());
            List<string> boardNum = BoardArea(BoardSize);
            
            string Player = "x";
            for(int i = 1; i <= 10; i++)
            {
                
                

                ShowBoard(BoardSize, boardNum);

                int PlayerMove = GetMove(Player);

                MakeMove(Player,PlayerMove, boardNum );

                Player = switchPlayer(Player);
            }
            
       
        }
         static List<string> BoardArea (int BoardSize)
        {
            List<string> PlayArea = new List<string>();
            for(int i = 1; i <= BoardSize * BoardSize; i++)
            {
                PlayArea.Add(i.ToString());
            }
            return PlayArea;
            
        }

        static void ShowBoard(int BoardSize,List<string> boardNum)
        {
            int SpaceNum = 0;
            for(int i = 1; i <= BoardSize; i++)
            {
                for(int c = 1; c <= BoardSize; c++)
                {
                    Console.Write($"|{boardNum[SpaceNum]}");
                    SpaceNum++;
                }
                Console.WriteLine(' ');
                Console.WriteLine("----------");
            }
        }

        static int GetMove (string Player)
        {
            Console.WriteLine($"Player {Player} What is your Move? ");
            int Move = int.Parse(Console.ReadLine());
            return Move;
        }

        static void MakeMove(string player, int PlayerMove, List<string> boardNum)
        {
            int choice = PlayerMove - 1;

            boardNum[choice] = player;
        }
        static string switchPlayer(string Player)
        {
            string NextPlayer = "x";
            if (Player == "x")
            {
                NextPlayer = "o";
            }
            return NextPlayer;
        }

        static bool checkWIn()
        {
            bool isWinner = false;
            
            return isWinner;
        }
        static int rows(int BoardSize, string player, List<string> boardNum)
        {
            int PlayerX = 0;
            int PlayerO= 0;
            int round = 0;
            int check = 0;
            for (int i = 1; i <= BoardSize; i++ )
            {
                if 

            }
        }
    }
}


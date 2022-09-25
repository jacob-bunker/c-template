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

            bool winning = false;
            bool TieCheck = true;
            while (winning != true || TieCheck != false)
            {
                
                

                ShowBoard(BoardSize, boardNum);

                int PlayerMove = GetMove(Player);

                MakeMove(Player,PlayerMove, boardNum );
                
                winning = checkWIn(BoardSize,Player,boardNum);
                
                Player = switchPlayer(Player);

                TieCheck= IsTie(boardNum);


                
            }
            if (winning == true)
            {
                ShowBoard(BoardSize,boardNum);
                Console.WriteLine($"Player {Player} is the winner!");
            }
            else if ( TieCheck == false)
            {
                ShowBoard(BoardSize,boardNum);
                Console.WriteLine("IT'S A TIE!");
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

        static bool checkWIn(int BoardSize, string player, List<string> boardNum)
        {
            bool isWinner = false;
            int rowscore = rows(BoardSize,player,boardNum);
            int columnScore = columns(BoardSize,player,boardNum);
            int DiagonalScore = Diagonals(BoardSize,player,boardNum);
            if(rowscore == BoardSize || columnScore == BoardSize || DiagonalScore == BoardSize)
            {
                isWinner = true;
            }
            return isWinner;
        }

        static bool IsTie(List<string> boardNum)
        {
            
            bool foundDigit = false;

            foreach (string value in boardNum)
            {
                if (char.IsDigit(value[0]))
                {
                    foundDigit = true;
                    break;
                }
            }

            return foundDigit;
        }

        static int rows(int BoardSize, string player, List<string> boardNum)
        {
           int checkspace = 0;
           int rowcheck = 0;
           int PlayerScore = 0;
           for(int i = 1; i <= BoardSize; i++)
           {
                if(boardNum[checkspace] == player)
                {
                    for(int c = 1; c <= BoardSize; c++)
                    {
                        if(boardNum[rowcheck] ==player)
                        {
                            PlayerScore ++;
                            
                        }
                        rowcheck ++;
                    }
                } 

                if(PlayerScore == BoardSize)
                {
                    break;
                }
                checkspace =+ BoardSize;
                rowcheck = checkspace;
                PlayerScore = 0;
           }
           return PlayerScore;
        }
        
        static int columns(int BoardSize, string player, List<string> boardNum)
        {
            int columnCheck = 0;
            int PlayerScore = 0;
            for (int i = 1; i<= BoardSize; i++)
            {
                if(boardNum[i - 1] == player)
                {
                   for(int c = 1; c <= BoardSize; c++)
                    {
                        if(boardNum[columnCheck] ==player)
                        {
                            PlayerScore ++;
                            
                        }
                        columnCheck += BoardSize + 1;
                    } 
                }
                if(PlayerScore == BoardSize)
                {
                    break;
                }
                columnCheck = 0;
                PlayerScore = 0;
            }
            return PlayerScore;
        }
        static int Diagonals(int BoardSize,string player,List<string> boardNum)
        {
            int DiagonalCheck = 0;
            int PlayerScore = 0;

            
            
            if(boardNum[0] == player)
            {
               for(int c = 1; c <= BoardSize; c++)
                {
                    if(boardNum[DiagonalCheck] ==player)
                    {
                        PlayerScore ++;
                        
                    }
                    DiagonalCheck += BoardSize;
                } 
            }
            if(PlayerScore != BoardSize)
            {
                DiagonalCheck = 0;
                PlayerScore = 0;
            }
            
            return PlayerScore;
            
        }
    }
}

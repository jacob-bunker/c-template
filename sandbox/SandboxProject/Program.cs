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

        static void GetNewBoard(int BoardSize,List<string> boardNum)
        {
            int SpaceNum = 0;
            for(int i = 1; i <= BoardSize; i++)
            {
                for(int c = 1; c <= BoardSize; c++)
                {
                    Console.Write($"|{boardNum[SpaceNum]}");
                    SpaceNum++;
                }
                Console.WriteLine('--');
            }
        }
    }
}


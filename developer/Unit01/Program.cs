using System;
using System.Collections.Generic;
namespace Unit01
{
    class Program
    {
        static void Main(string[] args)
        {
            /// tic tac toe - Jacob Bunker 
            int board = BoardArea();

       
        }
         static int BoardArea ()
        {
            Console.WriteLine("how big of a board do you want? ");
            int BoardSize = int.Parse(Console.ReadLine());

            return BoardSize;
        }

        static List<string> GetNewBoard(int BoardSize)
        {
            List<string> PlayArea = new List<string>();
            for(int i = 1; i <= BoardSize; i++)
            {
                PlayArea.Add(i.ToString());
            }
            return PlayArea;
        }
    }
}

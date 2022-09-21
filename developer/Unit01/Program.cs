using System;
using System.Collections.Generic;
namespace Unit01
{
    class Program
    {
        static void Main(string[] args)
        {
            /// tic tac toe - Jacob Bunker 
            List<string> board = BoardArea();

       
        }
         static List<string> BoardArea ()
        {
            Console.WriteLine("how big of a board do you want? ");
            int BoardSize = int.Parse(Console.ReadLine());

            List<string> PlayArea = new List<string>();
            for(int i = 1; i <= BoardSize; i++)
            {
                PlayArea.Add(i.ToString());
            }
            return PlayArea;
            
        }

        /*static List<string> GetNewBoard(int BoardSize)
        {
            
        }*/
    }
}

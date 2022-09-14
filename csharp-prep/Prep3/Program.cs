using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 3");
            
            int guessNum = -1;
            
            Random randomGen = new Random();
            int number = randomGen.Next(1, 20);

            do{
                Console.WriteLine("what is the magic number? ");
                string input = Console.ReadLine();
                guessNum = int.Parse(input);

            if ( number > guessNum)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guessNum)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("thats right!");
            }
            } while(guessNum != number);

        }
    }
}

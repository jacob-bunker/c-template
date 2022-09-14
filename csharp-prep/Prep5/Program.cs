using System;
using System.Collections.Generic;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 5");
            DisplayWelcomeMessage();

            string userName = PromptUserName();

            int userNum= PromptUserNum();

            int squaredNumber = SquareNumber(userNum);

            DisplayResult(userName, squaredNumber);
        }
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        static string PromptUserName()
        {
            Console.WriteLine("please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNum()
        {
            Console.WriteLine("Please enter your user number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}

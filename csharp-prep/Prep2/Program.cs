﻿using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 2");

            Console.Write("What is your grade percent? ");
            string userInput = Console.ReadLine();
            int grade = int.Parse(userInput);

            string letter = "";
            
            if(grade >= 90)
            {
                letter = "A";
            }

            else if(grade >=80)
            {
                letter = "B";
            }
            else if(grade >=70)
            {
                letter = "C";
            }
            else if(grade >=60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
            Console.WriteLine($"Your letter grade is {letter}");
            
            
            if (grade >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Unit02.Game
{
    /// <summary>
    /* represents a playing card with a value*/
    /// </summary> 
    public class Card
    {
        public int _value;
        public string _suit;

        public Card(){
            Random randomNumber = new Random();
            _value = randomNumber.Next(1,14);
            string[] suits={"hearts","diamonds","clubs","spades"};
            List<string> suitsList = new List<string>(suits);

            _suit = suitsList[randomNumber.Next(1,5) - 1];
            
        }

        public void Display(){
            Console.WriteLine($"A {_value} of {_suit}");
        }
    }
}
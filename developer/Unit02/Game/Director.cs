using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        Card _currentCard;
        bool _isPlaying = true;
        int _score = 300;
        string _userGuess;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            _currentCard = new Card();

            _userGuess = "lower";
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user for input.
        /// </summary>
        public void GetInputs()
        {
         Console.WriteLine($"the current card is  {_currentCard._value}");

         Console.WriteLine("higher or lower?(h/l)");
         _userGuess = Console.ReadLine();
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            //choose next card
            Card nextCard = new Card();
            Console.WriteLine($"the next card was {nextCard._value}");
            // compare card numbers to see whos higher and if it matches the users guess
            if(nextCard._value > _currentCard._value && _userGuess == "h" ||
            nextCard._value < _currentCard._value &&_userGuess == "l"){
                // win
                _score += 100;
            }
            else{
                // lose
                _score -= 75;
            }

            //make the current card equal the new one
            _currentCard = nextCard;


        }

        /// <summary>
        /// Displays the card and the score. 
        /// </summary>
        public void DoOutputs()
        {
            Console.WriteLine($"your score is {_score}");
            Console.WriteLine();

            if(_score <= 0)
            {
                _isPlaying = false;
            }
            else{
                Console.WriteLine("would you like to keep playing?(y/n) ");
                string playAgain = Console.ReadLine();

                if(playAgain == "y"){
                    _isPlaying = true;
                }
                else{
                    _isPlaying = false;
                }
            }
            
        }
    }
}



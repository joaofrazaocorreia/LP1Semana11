using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Controller
    {
        private int targetNumber;

        private RandomNumber randNum = new RandomNumber();

        public Controller()
        {
            targetNumber = randNum.GetRandomNumber();
        }
        
        public void Run(IView view)
        {
            int guess;
            int attempts = 0;
            bool guessedCorrectly = false;

            view.Welcome();

            // Game loop
            while (!guessedCorrectly)
            {
                guess = view.Guess();
                attempts++;

                if (guess == targetNumber)
                {
                    view.CorrectGuess(attempts);
                    guessedCorrectly = true;
                }
                else
                {
                    view.WrongGuess(guess, targetNumber);
                }
            }

            view.ThankYou();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class View : IView
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public int Guess()
        {
            Console.Write("Take a guess: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void CheckGuess(int guess, int targetNumber, int attempts)
        {
            if (guess == targetNumber)
            {
                Console.WriteLine(
                    "Congratulations! You guessed the number correctly!");
                Console.WriteLine("Number of attempts: " + attempts);
                guessedCorrectly = true;
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Too high! Try again.");
            }
        }

        public void ThankYou()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}
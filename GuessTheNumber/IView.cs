using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public interface IView
    {
        void Welcome();

        int Guess();

        void CorrectGuess(int attempts);
        void WrongGuess(int guess, int targetNumber);

        void ThankYou();
    }
}
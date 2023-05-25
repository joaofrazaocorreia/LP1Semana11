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

        void CheckGuess(int guess, int targetNumber, int attempts);

        void ThankYou();
    }
}
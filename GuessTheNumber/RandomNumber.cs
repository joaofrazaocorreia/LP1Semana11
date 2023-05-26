using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class RandomNumber
    {
        public int GetRandomNumber()
        {
            // Generate a random number
            Random random = new Random();

            // Return a number between 1 and 100
            return random.Next(1, 101);
        }
    }
}
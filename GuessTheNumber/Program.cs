using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            // Create controller
            Controller controller = new Controller();

            // Create view
            IView view = new View();

            // Start program
            controller.Run(view);
        }
    }
}
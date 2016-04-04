using System;

namespace GuessingGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Game game = new FormsGame();    
            //start the game with its initial guessings
            game.startGame("it lives in water", "Shark", "Monkey");
        }
    }
}

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
            game.startGame();
        }
    }
}

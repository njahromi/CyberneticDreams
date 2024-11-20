using System;

namespace CyberneticDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the game world
            GameWorld gameWorld = new GameWorld();

            // Create the player character
            Player player = new Player();

            // Start the game loop
            while (!gameWorld.IsGameOver)
            {
                // Display the current location and options
                gameWorld.DisplayCurrentLocation();

                // Get player input
                string input = Console.ReadLine();

                // Process player input
                gameWorld.ProcessInput(input, player);
            }

            // Game over
            Console.WriteLine("Game Over!");
        }
    }
}
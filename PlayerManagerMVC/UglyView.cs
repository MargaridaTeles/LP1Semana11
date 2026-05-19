using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class UglyView : IView
    {
        /// <summary>
        /// Shows the main menu.
        /// </summary>
        public string ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. Sort players");
            Console.WriteLine("0. Quit\n");
            Console.Write("Your choice > ");

            return Console.ReadLine();
        }

        public void ErrorMessage(string message)
        {
            Console.Error.WriteLine($"\n>>> {message} <<<\n");
        }

        public void ExitMessage()
        {
            Console.WriteLine("Bye!");
        }

        public void WaitForPlayer()
        {
            // Wait for user to press a key...
            Console.Write("\nPress any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine("\n");
        }

        public (string, int) AskForPlayerData()
        {
            // Ask for player info
            Console.WriteLine("\nInsert player");
            Console.WriteLine("-------------\n");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            return (name, score);
        }

        /// <summary>
        /// Show all players in a list of players. This method can be static
        /// because it doesn't depend on anything associated with an instance
        /// of the program. Namely, the list of players is given as a parameter
        /// to this method.
        /// </summary>
        /// <param name="playersToList">
        /// An enumerable object of players to show.
        /// </param>
        public void ListPlayers(IEnumerable<Player> playersToList)
        {
            Console.WriteLine("\nList of players");
            Console.WriteLine("-------------\n");

            // Show each player in the enumerable object
            foreach (Player p in playersToList)
                Console.WriteLine($" -> {p.Name} with a score of {p.Score}");

            Console.WriteLine();
        }

        public int AskForMinScore()
        {
            // Ask the user what is the minimum score
            Console.Write("\nMinimum score player should have? ");
            int minScore = Convert.ToInt32(Console.ReadLine());

            return minScore;
        }

        public void ShowSortMenu()
        {
            Console.WriteLine("Player order");
            Console.WriteLine("------------");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByScore}. Order by score");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByName}. Order by name");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByNameReverse}. Order by name (reverse)");
            Console.WriteLine("");
            Console.Write("> ");
        }

        public PlayerOrder AskForPlayerOrder()
        {
            Console.WriteLine("Player order");
            Console.WriteLine("------------");
            Console.WriteLine("0. By score");
            Console.WriteLine("1. By name");
            Console.WriteLine("2. By name (reverse)");
            Console.Write("> ");
            return Enum.Parse<PlayerOrder>(Console.ReadLine());
        }
    }
}
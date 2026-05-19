using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace PlayerManagerMVC
{
    /// <summary>
    /// The player listing program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program begins here.
        /// </summary>
        /// <param name="args">Not used.</param>
        private static void Main(string[] args)
        {
            // Initialize player comparers
            IComparer<Player> byName = new CompareByName(true);
            IComparer<Player> byNameReverse = new CompareByName(false);

            // Initialize the player list with two players using collection
            // initialization syntax
            PlayerList playerList = new PlayerList {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
            
            IView view = new UglyView();
            Controller controller = new Controller(playerList, byName, byNameReverse);
            controller.Run(view);

        }
    }
}

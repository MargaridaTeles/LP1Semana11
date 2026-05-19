using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class Controller
    {
        private readonly PlayerList playerList;
        private readonly IComparer<Player> compareByName;
        private readonly IComparer<Player> compareByNameReverse;

        public Controller(PlayerList list, 
                        IComparer<Player> byName, IComparer<Player> byNameReverse)
        {
            this.playerList = list;
            this.compareByName = byName;
            this.compareByNameReverse = byNameReverse;
        }

        /// <summary>
        /// Run the player listing program instance
        /// </summary>
        public void Run(IView view)
        {
            // We keep the user's option here
            string option;

            // Main program loop
            do
            {
                // Show menu and get user option
                option = view.ShowMenu();

                // Determine the option specified by the user and act on it
                switch (option)
                {
                    case "1":
                        // Insert player
                        (string name, int score) = view.AskForPlayerData();
                        // Create new player and add it to list
                        playerList.Add(new Player(name, score));
                        break;
                    case "2":
                        view.ListPlayers(playerList);
                        break;
                    case "3":
                        playerList.ListPlayersWithScoreGreaterThan(view);
                        break;
                    case "4":
                        playerList.SortPlayerList(view, compareByName, compareByNameReverse);
                        break;
                    case "0":
                        view.ExitMessage();
                        break;
                    default:
                        view.ErrorMessage("Unknown option!");
                        break;
                }
                view.WaitForPlayer();

                // Loop keeps going until players choses to quit (option 4)
            } while (option != "0");
        }
    }
}
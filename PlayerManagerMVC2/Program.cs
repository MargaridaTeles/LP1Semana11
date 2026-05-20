using System;
using System.Collections.Generic;
using System.IO;

namespace PlayerManagerMVC2
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

            string s;
            using StreamReader sr = new StreamReader(args[0]);
            PlayerList playerList = new PlayerList();


            // Initialize the player list with two players using collection
            // initialization syntax
            while((s = sr.ReadLine()) != null)
            {
                int lastSpace = s.LastIndexOf(' ');

                string name = s.Substring(0, lastSpace);
                int score = int.Parse(s.Substring(lastSpace + 1));

                playerList.Add(new Player(name, score));
            }
            
            IView view = new UglyView();
            Controller controller = new Controller(playerList, byName, byNameReverse);
            controller.Run(view);

        }
    }
}

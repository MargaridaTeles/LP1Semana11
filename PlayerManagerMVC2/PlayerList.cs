using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC2
{
    public class PlayerList : List<Player>
    {
        /// <summary>
        /// Get players with a score higher than a given value.
        /// </summary>
        /// <param name="minScore">Minimum score players should have.</param>
        /// <returns>
        /// An enumerable of players with a score higher than the given value.
        /// </returns>
        public IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            // Cycle all players in the original player list
            foreach (Player p in this)
            {
                // If the current player has a score higher than the
                // given value....
                if (p.Score > minScore)
                {
                    // ...return him as a member of the player enumerable
                    yield return p;
                }
            }
        }

        /// <summary>
        /// Show all players with a score higher than a user-specified value.
        /// </summary>
        public void ListPlayersWithScoreGreaterThan(IView view)
        {
            int minScore = view.AskForMinScore();

            // Get players with score higher than the user-specified value
            IEnumerable<Player> playersWithScoreGreaterThan =
                GetPlayersWithScoreGreaterThan(minScore);

            // List all players with score higher than the user-specified value
            view.ListPlayers(playersWithScoreGreaterThan);
        }

        

        /// <summary>
        ///  Sort player list by the order specified by the user.
        /// </summary>
        public void SortPlayerList(IView view, IComparer<Player> byName, IComparer<Player> byNameReverse)
        {
            view.ShowSortMenu();

            PlayerOrder playerOrder = Enum.Parse<PlayerOrder>(Console.ReadLine());

            switch (playerOrder)
            {
                case PlayerOrder.ByScore:
                    this.Sort();
                    break;
                case PlayerOrder.ByName:
                    this.Sort(byName);
                    break;
                case PlayerOrder.ByNameReverse:
                    this.Sort(byNameReverse);
                    break;
                default:
                    view.ErrorMessage("Unknown player order!");
                    break;
            }
        }
    }
}
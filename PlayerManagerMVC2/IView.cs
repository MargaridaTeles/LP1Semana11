using System;
using System.Collections.Generic;

namespace PlayerManagerMVC2
{
    public interface IView
    {
        string ShowMenu();

        void ErrorMessage(string msg);
        void ExitMessage();

        void WaitForPlayer();

        (string, int) AskForPlayerData();

        void ListPlayers(IEnumerable<Player> playersToList);

        int AskForMinScore();
        void ShowSortMenu();
        PlayerOrder AskForPlayerOrder();
    }
}
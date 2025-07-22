using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheasant
{
    internal class Manager
    {

        Pheasant pheasantGame;

        public Manager()
        {
            this.pheasantGame = new Pheasant();
        }


        public void StartNewGame()
        {
            pheasantGame.NewGame();
        }

        public void SetPlayersForGame()
        {
            pheasantGame.Init();
        }

        public void assignWinner()
        {
            pheasantGame.Players[pheasantGame.Winner].Win();
            pheasantGame.Players[pheasantGame.Winner].AddScore(1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pheasant
{
    internal class Player
    {
        string name, alias;
        int gamesPlayed, score;
        bool winner;

        public Player(string name, string alias)
        {
            this.name = name;
            this.alias = alias;
            this.gamesPlayed = 0;
            this.score = 0;
            this.winner = false;
        }

        public void PlayGame()
        {
            this.gamesPlayed++;
        }
        public void Win()
        {
            this.winner = true;
        }

        public void AddScore(int scoreToAdd)
        {
            this.score += scoreToAdd;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}

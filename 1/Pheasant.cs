using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheasant
{
    internal class Pheasant
    {
        int turn;
        int winner;
        List<Player> players, eliminaltedPlayers;

 
        internal List<Player> Players { get => players; set => players = value; }
        public int Winner { get => winner; set => winner = value; }

        public Pheasant()
        {
            Init();
            this.turn = 0;
        }
        public void Init()
        {
            this.Players = new List<Player>();
            this.eliminaltedPlayers = new List<Player>();
            int playerCount;
            do
            {
                Console.Write("How many player want to play? ");
            }
            while (!Int32.TryParse(Console.ReadLine(), null, out playerCount));


            for (int i = 0; i < playerCount; i++)
            {
                string name, alias;
                int gamesPlayed, score;
                bool winner;
                Console.Write("Enter the player's name: ");
                name = Console.ReadLine();
                Console.Write("Enter the player's alias: ");
                alias = Console.ReadLine();

                Players.Add(new Player(name, alias));
            }
        }

        public void NewGame()
        {
            foreach (Player ep in eliminaltedPlayers)
                players.Add(ep);
            foreach (Player p in Players)
                p.PlayGame();

            Console.WriteLine("Enter word letter: ");
            char let = Console.ReadKey().KeyChar;
            Console.WriteLine();
            string word = "";
            while (true)
            {
                Console.Write($"Enter the first word (2 letter or more that start with {let}): ");
                word = Console.ReadLine();

                if (word.Length >= 2 && word[0] == let)
                    break;
            }

            NextTurn();

            while (Players.Count > 1)
            {
                string prefix = word.Substring(word.Length - 2, 2);
                Console.Write($"{Players[turn]}: Enter word: " + prefix);
                word = prefix + Console.ReadLine();

                if (word.Equals(prefix))
                {
                    Console.WriteLine($"Player {Players[turn]} was eliminated!");
                    eliminaltedPlayers.Add(Players[turn]);
                    Players.RemoveAt(turn);
                }

                NextTurn();
            }

            Winner = turn;
            Console.WriteLine($"Player {Players[Winner]} won!!!!!!");
        }



        private void NextTurn()
        {
            turn++;
            if (turn >= Players.Count)
            {
                turn = 0;
            }
        }


    }
}

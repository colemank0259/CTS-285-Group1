using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Player
    {

        public Player(int players, int guessAmount)
        {
            Players = players;
            GuessAmount = guessAmount;
        }

        public Player()
        {
            Players = 0;
            GuessAmount = 0;
        }

        public int Players { get; set; }
        public int GuessAmount { get; set; }

        public static int CompareGuesses(Player x, Player y)
        {
            return x.GuessAmount.CompareTo(y.GuessAmount);
        }
    }
}

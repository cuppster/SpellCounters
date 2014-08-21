using System;
using System.Collections.Generic;

namespace SpellCounters.Models
{
    public class Game
    {
        public int Turn { get; set; }

        public Game ()
        {
            Players = new List<Player> ();
            Turn = 0;
        }

        public List<Player> Players { get; set; }

        public void Play() {

        }
    }
}


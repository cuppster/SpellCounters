using System;
using SpellCounters.Models;

namespace SpellCounters
{
    public static class Program
    {


        public static void Main(string[] args)
        {


            var game = new Game ();

            var player1 = new Player () { Name = "player 1" };
            var player2 = new Player () { Name = "player 2" };

            player1.Deck = (new SimpleRedDeck ()).MakeDeck ();
            player1.Deck.Shuffle ();

            player2.Deck = (new SimpleRedDeck ()).MakeDeck ();
            player2.Deck.Shuffle ();

            game.Players.Add (player1);
            game.Players.Add (player2);

            game.Play ();

        }
    }
}


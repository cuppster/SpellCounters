using System;
using SpellCounters.Models;
using SpellCounters.Game;

namespace SpellCounters
{
  public static class Program
  {


    public static void Main(string[] args)
    {


      var game = new MagicGame();

      var player1 = new Player() { Name = "player 1" };
      var player2 = new Player() { Name = "player 2" };

      player1.Deck = (new SimpleRedDeck()).MakeDeck();
      //player1.Deck.Shuffle();

      player2.Deck = (new SimpleRedDeck()).MakeDeck();
      //player2.Deck.Shuffle();

      game.AddPlayer(player1);
      game.AddPlayer(player2);

      game.Play();

    }
  }
}


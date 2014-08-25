using System;
using SpellCounters.Models;
using SpellCounters.Game;

namespace SpellCounters
{
  public static class Program
  {


    public static void Main(string[] args)
    {

      // new game
      var game = new MagicGame();

      // new players
      var player1 = new Player() { Name = "Player 1" };
      var player2 = new Player() { Name = "Player 2" };

      // give players a deck and shuffle
      player1.Deck = (new SimpleRedDeck()).MakeDeck();
      player1.Deck.Shuffle();

      player2.Deck = (new SimpleRedDeck()).MakeDeck();
      player2.Deck.Shuffle();

      // add players to game
      game.AddPlayer(player1);
      game.AddPlayer(player2);

      // play the game
      game.Play();

      // Keep the console window open in debug mode.
      Console.WriteLine("Press any key to exit.");
      Console.ReadKey();

    }
  }
}


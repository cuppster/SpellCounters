using SpellCounters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellCounters.Game
{
  class GamePlayer
  {

    private Player _player;
    private Deck _library;
    private Deck _graveyard;
    private Deck _hand;
    private Deck _field;

    public GamePlayer(Player player)
    {
      _player = player;
      _library = new Deck();
      _library.AddCards(player.Deck.Cards);

      _graveyard = new Deck();
      _hand = new Deck();
      _field = new Deck();

      Life = 20;

    }

    /// <summary>
    /// return a snapshot copy of the game player
    /// </summary>
    /// <returns></returns>
    public GamePlayer Copy()
    {
      // copy player
      var p = new GamePlayer(_player);

      // copy cards
      p._library.AddCards(_library.Cards);
      p._graveyard.AddCards(_graveyard.Cards);
      p._hand.AddCards(_hand.Cards);
      p._field.AddCards(_field.Cards);
      
      // copy life
      p.Life = Life;

      // return the copy
      return p;
    }

    public IEnumerable<Card> Hand { get { return _hand.Cards; } }

    //// check all mana sources to see if there's enough to cover the cost
    //public bool HasMana(CardCost cardCost)
    //{
    //  foreach (var c in cardCost.Cost)
    //  {
    //    // same number of mana


    //  }

    //}

    public bool HasCastMana(Card card)
    {
      return false;
    }

    public bool HasCardInHand(Card card)
    {
      return _hand.HasCard(card);
    }

    public bool PlayLandFromHand(Card card)
    {
      if (_hand.HasCard(card))
      {
        if (_hand.RemoveCard(card))
        {
          _field.AddCard(card);
          return true;
        }
      }

      return false;
    }




    public int Life { get; private set; }
  }
}

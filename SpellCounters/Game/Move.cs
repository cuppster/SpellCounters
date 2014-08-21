using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpellCounters.Models;

namespace SpellCounters.Game
{
  abstract class Move
  {
    public abstract bool CanMove(GameState state, GamePlayer player);
    public abstract void MakeMove(GameState state, GamePlayer player);
  }

  abstract class OneCardMove : Move
  {
    protected Card _card;
  }

  class PlayLand : OneCardMove
  {
    public PlayLand(Card card)
    {
      _card = card;
    }

    public override bool CanMove(GameState state, GamePlayer player)
    {
      // if player has card
      if (!player.HasCardInHand(_card))
        return false;

      // if player has mana
      player.PlayLandFromHand(_card);

      // OK
      return true;
    }

    public override void MakeMove(GameState state, GamePlayer player)
    {
      if (!CanMove(state, player))
        throw new Exception("Can't make the move!");

      // remove card from hand and put into play
      //player.


    }
  }
}

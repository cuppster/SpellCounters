using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpellCounters.Models;

namespace SpellCounters.Game
{
  public abstract class Move
  {
    public abstract bool CanMove(GameState state);
    public abstract void MakeMove(GameState state);
  }

  public abstract class OneCardMove : Move
  {
    protected Card _card;
  }

  public class PlayLand : OneCardMove
  {
    public PlayLand() { }

    public override bool CanMove(GameState state)
    {
      // is there a basic land in player's hand?
      var basicLand = state.ActivePlayer.Hand.FirstOrDefault(c => c.IsBasicLand);
      if (null == basicLand)
        return false;

      // save for later...
      _card = basicLand;

      // OK
      return true;
    }

    public override void MakeMove(GameState state)
    {
      if (!CanMove(state))
        throw new Exception("Can't make the move!");

      // if player has mana
      state.ActivePlayer.PlayLandFromHand(_card);
    }

    public override string ToString()
    {
      return string.Format("<PlayLand {0}>", _card);
    }
  }
}

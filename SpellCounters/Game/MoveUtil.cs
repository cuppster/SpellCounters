using SpellCounters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellCounters.Game
{
  public static class MoveUtil
  {


    public static Card CanPlayALandFromHand(GamePlayer player)
    {

      return player.Hand.FirstOrDefault(card => card.IsBasicLand);

    }


  }
}

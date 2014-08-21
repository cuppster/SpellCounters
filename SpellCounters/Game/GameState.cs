using SpellCounters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellCounters.Game
{
  class GameState
  {

    private List<GamePlayer> _players;

    public GameState()
    {
      _players = new List<GamePlayer>();
    }

    public void AddPlayer(Player player)
    {
      _players.Add(new GamePlayer(player));
    }

    public GameState Copy()
    {
      // new state
      var g = new GameState();

      // copy all the players
      foreach (var player in _players)
      {
        g._players.Add(player.Copy());
      }

      // return the copy
      return g;
    }


  }
}

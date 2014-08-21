using SpellCounters.Models;
using System.Collections.Generic;

namespace SpellCounters.Game
{
  public class MagicGame
  {
   
    private List<GamePlayer> _players;

    public MagicGame()
    {
      _players = new List<GamePlayer>();
      //Turn = 0;
    }

    //public int Turn { get; set; }

    public void AddPlayer(Player player)
    {
      _players.Add(new GamePlayer(player));
    }

    public void Play()
    {

    }
  }
}


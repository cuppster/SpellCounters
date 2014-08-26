using SpellCounters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellCounters.Game
{
  public class GameState
  {

    private List<GamePlayer> _players;
    private GamePlayer _activePlayer;
    private List<Move> _moves;

    private int _score = 0;

    public GameState()
    {
      // initial state
      _players = new List<GamePlayer>();
      _moves = new List<Move>();
    }

    private GameState(GameState prevState) : this()
    {

      // copy all the players
      foreach (var player in prevState._players)
        _players.Add(player.Copy());

      // remember active player
      _activePlayer = prevState._activePlayer;
    }

    public void AddPlayer(GamePlayer player)
    {
      // create new game player and add to list of players
      //var p = new GamePlayer(player);
      _players.Add(player);
    }

    public void AddMove(Move move)
    {
      _moves.Add(move);
    }

    public Move[] Moves()
    {
      return _moves.ToArray();
    }

    public void NextPlayer()
    {
      foreach (var p in _players)
      {
        if (!p.Equals(_activePlayer))
        {
          _activePlayer = p;
          return;
        }
      }
    }

    public int Score { get { return _score; } set { _score = value; } }


    public GamePlayer ActivePlayer { get { return _activePlayer; } }

    public GameState Copy()
    {
      // new state
      var g = new GameState(this);

      // return the copy
      return g;
    }


  }
}

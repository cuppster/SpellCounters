using SpellCounters.Models;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Diagnostics;

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

      // first game state
      var state = new GameState();

      // add players
      foreach (var p in _players)
      {
        // add player
        state.AddPlayer(p);

        // initial draw of 7 cards
        p.FirstDraw();
      }

      // new AI
      var AI = new AI();

      // advance to next/first player
      state.NextPlayer();

      // find the best move
      foreach (var turn in Enumerable.Range(0, 2))
      {

        Debug.WriteLine(string.Format("Turn: {0}; player {1}", turn, state.ActivePlayer));
        var winningState = AI.GetBestMove(state, 5);

        // description of moves that got to this winning state
        var moves = string.Join("\n", winningState.Moves().Select(m => m.ToString()));
        Debug.WriteLine(string.Format("Winning Move for {0}: {1}", winningState.ActivePlayer, moves));

        // next player
        state = winningState;
        //state.NextPlayer();
      }
    }
  }
}


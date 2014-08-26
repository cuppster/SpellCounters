using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SpellCounters.Game
{
  public class AI
  {

    private GameSteps _gameSteps;
    private GamePlayer _startPlayer;

    public AI()
    {

      // start the AI
      // AI asks GameSteps for a new GameState
      // GameSteps advances turn counter
      // GameState has a score, representing the score the player has at the end of their turn, evaulating their position in the game state


      _gameSteps = new GameSteps();
    }

    /// <summary>
    /// Implementation of the minimax algorithm.  Determines the best move for the current 
    /// board by playing every move combination until the end of the game.
    /// </summary>
    public GameState GetBestMove(GameState currState, int depth)
    {
      // who is going first (maximizing)
      if (null == _startPlayer)
        _startPlayer = currState.ActivePlayer;

      // terminal condition
      if (depth == 0)
        return currState;     

      // calulcate possible next moves
      // apply moves to the current states to get new states

      var nextStates = _gameSteps.NextState(currState);

      if (currState.ActivePlayer.Equals(_startPlayer))
      {
        // maximizing player

        GameState bestState = null;
        foreach (var child in nextStates)
        {
          var val = GetBestMove(child, depth - 1);
          if (null == bestState)
            bestState = val;

          if (val.Score > bestState.Score)
            bestState = val;
        }

        
        Debug.WriteLine("MAXimizing player: {0}", currState.ActivePlayer);

        return bestState;
      }
      else
      {
        // minimizing player
        

        GameState bestState = null;
        foreach (var child in nextStates)
        {
          var val = GetBestMove(child, depth - 1);
          if (null == bestState)
            bestState = val;

          if (val.Score < bestState.Score)
            bestState = val;
        }

        Debug.WriteLine("MINimizing player: {0}", currState.ActivePlayer);

        return bestState;
      }
    }
  }
}

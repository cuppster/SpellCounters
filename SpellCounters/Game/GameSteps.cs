using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SpellCounters.Game
{
  public enum PlySteps : int
  {
    P1_PLAY_LAND,
    P1_PLAY_CREATURE,
  }

  public class GameSteps
  {

    private int _plyStepIndex = -1;
    private static List<PlySteps> plySteps;

    static GameSteps() {
      plySteps = new List<PlySteps>();
      plySteps.Add(PlySteps.P1_PLAY_LAND);
    }

    public GameSteps()
    {
      // NOOP
    }

    public IEnumerable<GameState> NextState(GameState state)
    {

      // advance ply step, initial value of -1 will advance to 0
      _plyStepIndex = 1 + _plyStepIndex;

      // clone current state
      var nextState = state.Copy();  

      // go to the beginning
      if (plySteps.Count == _plyStepIndex)
      {
        _plyStepIndex = 0;       
      }

      // advance the payer
      nextState.NextPlayer();

      // create moves
      switch (plySteps[_plyStepIndex])
      {

        case PlySteps.P1_PLAY_LAND :
          PlayLand(nextState);
          break;

      }
     

      // return new state
      yield return nextState;
    }

    private void PlayLand(GameState state)
    {
      Debug.WriteLine("-- trying PlayLand: {0}", state.ActivePlayer);

      // create the move
      var move = new PlayLand();
      if (move.CanMove(state))
      {

        // make the move
        move.MakeMove(state);

        // score the result of applying the moves
        state.Score = 100;

        // record move in state
        state.AddMove(move);
      }


    }
  }
}

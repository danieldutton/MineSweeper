using MSweeper.GameModeFactory.Interfaces;
using System;

namespace MSweeper.GameModeFactory.EventArg
{
    public class ChosenGameModeEventArgs : EventArgs
    {
        public IGameMode GameMode { get; private set; }

        public ChosenGameModeEventArgs(IGameMode gameMode)
        {
            GameMode = gameMode;            
        }
    }
}

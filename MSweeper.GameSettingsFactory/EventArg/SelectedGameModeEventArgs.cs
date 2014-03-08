using MSweeper.GameModeFactory.Interfaces;
using System;

namespace MSweeper.GameModeFactory.EventArg
{
    public class SelectedGameModeEventArgs : EventArgs
    {
        public IGameMode GameMode { get; private set; }

        public SelectedGameModeEventArgs(IGameMode gameMode)
        {
            GameMode = gameMode;
        }
    }
}

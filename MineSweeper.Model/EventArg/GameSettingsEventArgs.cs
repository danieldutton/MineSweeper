using MineSweeper.GameModeFactory.Interfaces;
using System;

namespace MineSweeper.Model.EventArg
{
    public class GameSettingsEventArgs : EventArgs
    {
        public IGameMode GameMode { get; set; }

        public GameSettingsEventArgs(IGameMode gameMode)
        {
            GameMode = gameMode;
        }
    }
}

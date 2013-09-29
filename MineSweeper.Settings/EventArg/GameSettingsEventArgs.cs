using MineSweeper.Settings.Interfaces;
using System;

namespace MineSweeper.Settings.EventArg
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

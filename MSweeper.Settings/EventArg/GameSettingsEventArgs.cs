using MSweeper.Settings.Interfaces;
using System;

namespace MSweeper.Settings.EventArg
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

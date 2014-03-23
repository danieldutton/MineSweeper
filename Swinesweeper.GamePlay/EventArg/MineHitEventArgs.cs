using System;

namespace Swinesweeper.GamePlay.EventArg
{
    public sealed class MineHitEventArgs : EventArgs
    {
        public Tile[,] Grid { get; private set; }

        public MineHitEventArgs(Tile[,] grid)
        {
            Grid = grid;
        }
    }
}

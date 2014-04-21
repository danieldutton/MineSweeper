using System;

namespace Swinesweeper.GamePlay.EventArg
{
    public sealed class TileClearEventArgs : EventArgs
    {
        public Tile[,] Grid { get; private set; }

        public int XPos { get; private  set; }

        public int YPos { get; private set; }

        public TileClearEventArgs(Tile[,] grid, int xPos, int yPos)
        {
            Grid = grid;
            XPos = xPos;
            YPos = yPos;
        }
    }
}

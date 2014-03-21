using System;

namespace Swinesweeper.Model.EventArg
{
    public class TileActivityEventArgs : EventArgs
    {
        public int XPos { get; private set; }

        public int YPos { get; private set; }

        public bool IsMined { get; private set; }


        public TileActivityEventArgs(int xPos, int yPos, bool isMined)
        {
            XPos = xPos;
            YPos = yPos;
            IsMined = isMined;
        }
    }
}

using System;

namespace MSweeper.Model.EventArg
{
    public class TileActivityEventArgs : EventArgs
    {
        public int GridPositionX { get; set; }

        public int GridPositionY { get; set; }

        public bool IsMined { get; set; }


        public TileActivityEventArgs(int xPos, int yPos, bool isMined)
        {
            GridPositionX = xPos;
            GridPositionY = yPos;
            IsMined = isMined;
        }
    }
}

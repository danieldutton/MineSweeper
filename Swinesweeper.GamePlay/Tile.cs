using Swinesweeper.GamePlay.EventArg;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Swinesweeper.GamePlay
{
    public class Tile : PictureBox
    {
        public static event EventHandler<MineHitEventArgs> MineHit;

        public static event EventHandler<TileClearEventArgs> TileClear;

        public static event EventHandler<EventArgs> FlagPlaced;

        public static event EventHandler<EventArgs> FlagRemoved;

        public static Tile[,] Grid { get; set; }

        public int GridPositonX { get; set; }

        public int GridPositionY { get; set; }

        public bool IsMined { get; set; }

        public bool IsFlagged { get; set; }

        public bool IsCleared { get; set; }

        private int _rightClickCount = 1;

        public static int FlagCount { get; set; }

        public static int MineCount { get; set; }

        public static int TileCount { get; set; }

        public static int CorrectFlagCount { get; set; }

        public Label LblMineCount = new Label();


        protected override void OnClick(EventArgs e)
        {
            var mouseEvent = e as MouseEventArgs;
            if (mouseEvent == null) return;

            if (mouseEvent.Button == MouseButtons.Left)
                SelectTile();
            
            if (mouseEvent.Button == MouseButtons.Right)
            {              
                if(_rightClickCount == 1 && !IsFlagged)
                    AddFlag();
                else if(_rightClickCount == 2 && IsFlagged)
                    RemoveFlag();
            }         
            base.OnClick(e);   
        }

        public void SelectTile()
        {
            if (IsMined && !IsFlagged)
                OnMineHit(new MineHitEventArgs(Grid));    
                
            if (!IsFlagged && !IsCleared)
                RemoveTile();    
        }

        public void RemoveTile()
        {
            IsCleared = true;
            TileCount--;
            OnTileClear(new TileClearEventArgs(Grid, GridPositonX, GridPositionY));
        }

        public void AddFlag()
        {
            if (IsCleared || IsFlagged) return;
            if (FlagCount == 0) return;
            
            _rightClickCount = 2;
            
            BackColor = Color.YellowGreen;
            IsFlagged = true;
            FlagCount--;

            if (IsMined)
                CorrectFlagCount++;

            OnFlagPlaced();
        }

        public void RemoveFlag()
        {
            if (IsCleared == false && IsFlagged)
            {
                _rightClickCount = 1;
                BackColor = Color.SaddleBrown;              
                IsFlagged = false;
                FlagCount++;

                if(IsMined)
                    CorrectFlagCount--;
                
                OnFlagRemoved();
            } 
        }

        protected static void OnMineHit(MineHitEventArgs e)
        {
            EventHandler<MineHitEventArgs> handler = MineHit;
            if (handler != null) handler(null, e);
        }

        protected static void OnTileClear(TileClearEventArgs e)
        {
            EventHandler<TileClearEventArgs> handler = TileClear;
            if (handler != null) handler(null, e);
        }

        protected static void OnFlagPlaced()
        {
            EventHandler<EventArgs> handler = FlagPlaced;
            if (handler != null) handler(null, EventArgs.Empty);
        }

        protected static void OnFlagRemoved()
        {
            EventHandler<EventArgs> handler = FlagRemoved;
            if (handler != null) handler(null, EventArgs.Empty);
        }
    }
}

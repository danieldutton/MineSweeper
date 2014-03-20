using MSweeper.Model.EventArg;
using MSweeper.Model.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MSweeper.Model
{
    public class Tile : PictureBox, ITile
    {
        public event EventHandler<TileActivityEventArgs> TileSelected;
       
        public event EventHandler<TileActivityEventArgs> MineHit;
      
        public event EventHandler<TileActivityEventArgs> MineFree;

        public Tile[,] Grid { get; set; }

        public bool IsMined { get; set; }

        public bool IsFlagged { get; set; }

        public bool IsCleared { get; set; }

        public int GridPositonX { get; set; }

        public int GridPositionY { get; set; }

        private int _rightClickCount = 1;

        public Label LblMineCOunt = new Label();

        public static int FlagCount { get; set; }

        public static int MineCount { get; set; }

        public static int TileCount { get; set; }

        public static int CorrectFlagCount { get; set; }


        protected override void OnClick(EventArgs e)
        {
            var mouseEvent = e as MouseEventArgs;
            if (mouseEvent == null) return;

            if (mouseEvent.Button == MouseButtons.Left)
                SelectTile();
            
            if (mouseEvent.Button == MouseButtons.Right)
            {              
                if(_rightClickCount == 1)
                    AddFlagToTile();
                else if(_rightClickCount == 2)
                    RemoveFlagFromTile();
            }         
            base.OnClick(e);

            if (CorrectFlagCount == MineCount && TileCount == MineCount)
                MessageBox.Show("Game Won");
        }

        public void SelectTile()
        {
            if (IsMined)
                ConfirmGameOver();    
                
            if (!IsFlagged && !IsCleared)
                RemoveTile();    
        }

        public void RemoveTile()
        {
            BackColor = Color.White;
            IsCleared = true;
            GridCascader.FloodFill(Grid, GridPositonX, GridPositionY);
            TileCount--;

        }

        public void AddFlagToTile()
        {
            if (IsCleared || IsFlagged) return;
            if (FlagCount == 0) return;
            
            _rightClickCount = 2;
            
            BackColor = Color.Red;
            IsFlagged = true;
            FlagCount--;

            if (IsMined)
                CorrectFlagCount++;
        }

        public bool IsGameWon()
        {
            return true;
        }

        public void RemoveFlagFromTile()
        {
            if (IsCleared == false && IsFlagged)
            {
                _rightClickCount = 1;
                BackColor = Color.Teal;              
                IsFlagged = false;
                FlagCount++;

                if(IsMined)
                CorrectFlagCount--;
            }  
        }

        private void DsplayResultsForm()
        {
            
        }

        private void ConfirmGameOver()
        {
            MessageBox.Show("Game Over");
        }

        protected virtual void OnTileSelected(TileActivityEventArgs e)
        {
            EventHandler<TileActivityEventArgs> handler = TileSelected;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnMineHit(TileActivityEventArgs e)
        {
            EventHandler<TileActivityEventArgs> handler = MineHit;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnMineFree(TileActivityEventArgs e)
        {
            EventHandler<TileActivityEventArgs> handler = MineFree;
            if (handler != null) handler(this, e);
        }
    }
}

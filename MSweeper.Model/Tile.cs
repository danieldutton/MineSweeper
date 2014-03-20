using MSweeper.Model.EventArg;
using MSweeper.Model.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MSweeper.Model
{
    public class Tile : PictureBox, ITile
    {
        #region Events

        public event EventHandler<TileActivityEventArgs> TileSelected;
       
        public event EventHandler<TileActivityEventArgs> MineHit;
      
        public event EventHandler<TileActivityEventArgs> MineFree;

        #endregion

        public Tile[,] Grid { get; set; }

        public bool IsMined { get; set; }

        public bool IsFlagged { get; set; }

        public bool IsCleared { get; set; }

        public int GridPositonX { get; set; }

        public int GridPositionY { get; set; }

        private int _rightClickCount = 1;

        public Label MineCount = new Label();

        public static int FlagCount { get; set; }

        public static int TileCount { get; set; }


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
        }

        public void SelectTile()
        {
            if (IsMined)
            {
                //only if a tile is confirmed selected do we pass details of the grid to calculate etc

                OnMineHit(new TileActivityEventArgs(GridPositonX, GridPositionY, IsMined));
                ConfirmGameOver();    
            }
                
            if (!IsFlagged && !IsCleared)
            {
                RemoveTile(); 
                
            }               
        }

        public void RemoveTile()
        {
            BackColor = Color.White;
            IsCleared = true;
            GridCascader.FloodFill(Grid, GridPositonX, GridPositionY);
            TileCount++;

        }

        public void AddFlagToTile()
        {
            if (IsCleared || IsFlagged) return;
            
            _rightClickCount = 2;
            
            BackColor = Color.Red;
            IsFlagged = true;
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
            }  
        }

        private void ConfirmGameOver()
        {
        }

        #region Event Invocators

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

        #endregion

    }
}

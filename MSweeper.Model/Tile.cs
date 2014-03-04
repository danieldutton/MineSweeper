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

        public bool IsMined { get; set; }

        public bool IsFlagged { get; set; }

        public bool IsSelected { get; set; }

        public int GridPositonX { get; set; }

        public int GridPositionY { get; set; }

        private int _rightClickCount = 1;


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
                OnTileSelected(new TileActivityEventArgs(GridPositonX, GridPositionY, IsMined));           
                GameOver();    
            }
                
            if (!IsFlagged && !IsSelected)
            {
                BackColor = Color.Blue;
                IsSelected = true;         
            }
        }

        public void AddFlagToTile()
        {
            if (!IsSelected && !IsFlagged)
            {
                _rightClickCount = 2;
                BackColor = Color.Orange;
                IsFlagged = true;    
            }  
        }

        public void RemoveFlagFromTile()
        {
            if (IsSelected == false && IsFlagged)
            {
                _rightClickCount = 1;
                BackColor = Color.IndianRed;              
                IsFlagged = false;   
            }  
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

        private void GameOver()
        {
            MessageBox.Show("Game Over");
        }

    }
}

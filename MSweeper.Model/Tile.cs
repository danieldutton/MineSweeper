using MSweeper.Model.EventArg;
using MSweeper.Model.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MSweeper.Model
{
    public class Tile : PictureBox, ITile
    {
        public Tile[,] Grid { get; set; }

        public event EventHandler<TileActivityEventArgs> TileSelected;
       
        public event EventHandler<TileActivityEventArgs> MineHit;
      
        public event EventHandler<TileActivityEventArgs> MineFree;       

        public bool IsMined { get; set; }

        public bool IsFlagged { get; set; }

        public bool IsSelected { get; set; }

        public bool IsOpen { get; set; }

        public int GridPositonX { get; set; }

        public int GridPositionY { get; set; }

        private int _rightClickCount = 1;

        public Label MineCount = new Label();


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
                ConfirmGameOver();    
            }
                
            if (!IsFlagged && !IsSelected)
            {
                RemoveTile(); 
                GridCascader.FloodFill(Grid, GridPositonX, GridPositionY);
            }
                
        }

        public void RemoveTile()
        {
            BackColor = Color.White;
            IsSelected = true;
            MineCount.Location = new Point(0, 0);
            MineCount.Visible = true;
            MineCount.ForeColor = Color.DarkGreen;
            MineCount.BackColor = Color.Transparent;
            Controls.Add(MineCount);
        }

        public void AddFlagToTile()
        {
            if (IsSelected || IsFlagged) return;
            
            _rightClickCount = 2;
            
            BackColor = Color.Red;
            IsFlagged = true;
        }

        public void RemoveFlagFromTile()
        {
            if (IsSelected == false && IsFlagged)
            {
                _rightClickCount = 1;
                BackColor = Color.Black;              
                IsFlagged = false;   
            }  
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

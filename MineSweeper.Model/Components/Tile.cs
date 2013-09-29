using MineSweeper.Model.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweeper.Model.Components
{
    public class Tile : PictureBox, ITile
    {
        public event EventHandler<EventArgs> TileSelected;

        public event EventHandler<EventArgs> MineHit;

        public event EventHandler<EventArgs> MineFree;

        
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
                GameOver();
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

        protected virtual void OnTileSelected()
        {
            EventHandler<EventArgs> handler = TileSelected;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnMineHit()
        {
            EventHandler<EventArgs> handler = MineHit;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnMineFree()
        {
            EventHandler<EventArgs> handler = MineFree;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        private void GameOver()
        {
            MessageBox.Show("Game Over");
        }

    }
}

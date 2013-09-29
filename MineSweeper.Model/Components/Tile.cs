using System.Drawing;
using System.Windows.Forms;
using MineSweeper.Model.Interfaces;

namespace MineSweeper.Model.Components
{
    public class Tile : PictureBox, ITile
    {
        public bool IsMined { get; set; }

        public bool IsFlagged { get; set; }

        public bool HasBeenSelected { get; set; }

        public int GridPositonX { get; set; }

        public int GridPositionY { get; set; }

        private int _rightClickCount = 1;


        protected override void OnClick(System.EventArgs e)
        {
            var mouseEvent = e as MouseEventArgs;
            if (mouseEvent == null) return;

            if (mouseEvent.Button == MouseButtons.Left)
                SelectTile();
            
            if (mouseEvent.Button == MouseButtons.Right)
            {              
                if(_rightClickCount == 1)
                    FlagTile();
                else if(_rightClickCount == 2)
                    UnFlagTile();
            }         
            base.OnClick(e);
        }

        public void SelectTile()
        {
            if (IsMined)
                GameOver();
            if (!IsFlagged && !HasBeenSelected)
            {
                BackColor = Color.Blue;
                HasBeenSelected = true;         
            }
        }

        public void FlagTile()
        {
            if (!HasBeenSelected && !IsFlagged)
            {
                _rightClickCount = 2;
                BackColor = Color.Orange;
                IsFlagged = true;    
            }  
        }

        public void UnFlagTile()
        {
            if (HasBeenSelected == false && IsFlagged)
            {
                _rightClickCount = 1;
                BackColor = Color.IndianRed;              
                IsFlagged = false;   
            }  
        }

        private void GameOver()
        {
            MessageBox.Show("Game Over");
        }

    }
}

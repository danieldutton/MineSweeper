using Swinesweeper.GamePlay.Interfaces;
using System.Drawing;

namespace Swinesweeper.GamePlay
{
    public class TilePainter : ITilePainter
    {
        public void DisplayMineCount(Tile[,] grid, int x, int y)
        {
            grid[x, y].BackColor = Color.SlateGray;
            grid[x, y].IsCleared = true;
            grid[x, y].LblMineCount.Location = new Point(2, 2);
            grid[x, y].LblMineCount.Visible = true;
            grid[x, y].LblMineCount.ForeColor = Color.White;
            grid[x, y].LblMineCount.BackColor = Color.Transparent;
            grid[x, y].Controls.Add(grid[x, y].LblMineCount);
        }
    }
}

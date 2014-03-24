using System.Drawing;
using Swinesweeper.GamePlay.Interfaces;

namespace Swinesweeper.GamePlay
{
    public class TileCascader : ITileCascader
    {
        public void CascadeTile(Tile[,] grid, int x, int y)
        {
            Tile cell = grid[x, y];
            cell.IsCleared = true;
            DisplayMineCount(grid, x, y);

            if (cell.IsMined)
                return;

            if (cell.LblMineCount.Text != "0")
                return;

            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i <= 0 || i >= grid.GetLength(0) ||
                        j <= 0 || j >= grid.GetLength(1))
                        continue;

                    Tile neighbour = grid[i, j];
                    if (!neighbour.IsCleared)
                    {
                        DisplayMineCount(grid,i, j);
                        CascadeTile(grid, i, j);
                        Tile.TileCount--;
                    }
                }
        }

        public void CascadeAll(Tile[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].IsMined)
                        grid[i, j].Image = Properties.Resources.pig_mine;
                    DisplayMineCount(grid, i, j);
                }
            }
        }

        private void DisplayMineCount(Tile[,] grid, int x, int y)
        {
            grid[x, y].BackColor = Color.SlateGray;
            grid[x, y].LblMineCount.Location = new Point(2, 2);
            grid[x, y].LblMineCount.Visible = true;
            grid[x, y].LblMineCount.ForeColor = Color.White;
            grid[x, y].LblMineCount.BackColor = Color.Transparent;
            grid[x, y].Controls.Add(grid[x, y].LblMineCount);
        }
    }
}
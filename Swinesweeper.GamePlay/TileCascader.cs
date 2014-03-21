using System.Drawing;

namespace Swinesweeper.GamePlay
{
    public class TileCascader
    {
        public static void CascadeSelectedTile(Tile[,] grid, int x, int y)
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
                        CascadeSelectedTile(grid, i, j);
                        Tile.TileCount--;
                    }
                }
        }

        public static void CascadeAll(Tile[,] grid)
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

        public static void DisplayMineCount(Tile[,] grid, int x, int y)
        {
            grid[x, y].BackColor = Color.Gray;
            grid[x, y].LblMineCount.Location = new Point(2, 2);
            grid[x, y].LblMineCount.Visible = true;
            grid[x, y].LblMineCount.ForeColor = Color.White;
            grid[x, y].LblMineCount.BackColor = Color.Transparent;
            grid[x, y].Controls.Add(grid[x, y].LblMineCount);
        }
    }
}
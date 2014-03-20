using System.Drawing;

namespace MSweeper.Model
{
    public class GridCascader
    {
        public static void FloodFill(Tile[,] grid, int x, int y)
        {
            Tile cell = grid[x, y];
            cell.IsCleared = true;
            DisplayMineCount(grid, x, y);

            if (cell.IsMined)
                return;

            if (cell.MineCount.Text != "0")
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
                        FloodFill(grid, i, j);
                    }
                }
        }

        public static void DisplayMineCount(Tile[,] grid, int x, int y)
        {
            grid[x, y].BackColor = Color.LightGray;
            grid[x, y].MineCount.Location = new Point(0, 0);
            grid[x, y].MineCount.Visible = true;
            grid[x, y].MineCount.ForeColor = Color.White;
            grid[x, y].MineCount.BackColor = Color.Transparent;
            grid[x, y].Controls.Add(grid[x, y].MineCount);   
        }
    }
}
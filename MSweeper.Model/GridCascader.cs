using System.Drawing;

namespace MSweeper.Model
{
    public class GridCascader
    {
        public static bool FloodFill(Tile[,] grid, int x, int y)
        {
            Tile cell = grid[x, y];
            cell.IsOpen = true;

            if (cell.IsMined)
                return false;

            if (cell.MineCount.Text != "0")
            {
                
                return true;   
            }
                

            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i < 0 || i >= grid.GetLength(0) ||
                        j < 0 || j >= grid.GetLength(1))
                        continue;

                    Tile neighbour = grid[i, j];
                    if (!neighbour.IsOpen)
                    {
                        cell.BackColor = Color.LightGray;
                        grid[x, y].MineCount.Location = new Point(0, 0);
                        grid[x, y].MineCount.Visible = true;
                        grid[x, y].MineCount.ForeColor = Color.DarkGreen;
                        grid[x, y].MineCount.BackColor = Color.Transparent;
                        grid[x, y].Controls.Add(grid[x, y].MineCount);
                        FloodFill(grid, i, j);   
                    }
                        
                }

            return true;
        }
    }
}

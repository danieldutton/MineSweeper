using Swinesweeper.GamePlay.Interfaces;
using System;

namespace Swinesweeper.GamePlay
{
    public class PigCounter : ITileCounter
    {
        public void Count(Tile[,] grid)
        {
            if(grid == null) throw new ArgumentNullException("grid");

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (!grid[i, j].IsMined)
                    {
                        int count = 0;

                        for (int p = i - 1; p <= i + 1; p++)
                        {
                            for (int q = j - 1; q <= j + 1; q++)
                            {
                                if (0 <= p && p < grid.GetLength(0) && 0 <= q && q < grid.GetLength(0))
                                {
                                    if (grid[p, q].IsMined)
                                        ++count;
                                }
                            }
                        }
                        grid[i, j].LblMineCount.Text = count.ToString();
                    }
                }
            }
        }
    }
}
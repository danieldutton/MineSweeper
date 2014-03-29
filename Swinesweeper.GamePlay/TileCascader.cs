using Swinesweeper.GamePlay.Interfaces;

namespace Swinesweeper.GamePlay
{
    public class TileCascader : ITileCascader
    {
        private readonly ITilePainter _tilePainter;

        public TileCascader()
        {
        }

        public TileCascader(ITilePainter tilePainter)
        {
            _tilePainter = tilePainter;
        }

        public void CascadeTile(Tile[,] grid, int x, int y)
        {
            Tile cell = grid[x, y];
            cell.IsCleared = true;
            _tilePainter.DisplayMineCount(grid, x, y);

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
                        _tilePainter.DisplayMineCount(grid,i, j);
                        CascadeTile(grid, i, j);
                        Tile.TileCount--;
                    }
                }
        }

        public Tile[,] CascadeAll(Tile[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].IsMined)
                        grid[i, j].Image = Properties.Resources.pig_mine;
                    
                    _tilePainter.DisplayMineCount(grid, i, j);
                }
            }
            return grid;
        }        
    }
}
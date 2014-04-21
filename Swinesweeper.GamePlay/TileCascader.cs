using Swinesweeper.GamePlay.Interfaces;
using System;

namespace Swinesweeper.GamePlay
{
    public class TileCascader : ITileCascader
    {
        private readonly ITilePainter _tilePainter;


        public TileCascader(ITilePainter tilePainter)
        {
            _tilePainter = tilePainter;
        }

        public Tile[,] CascadeTile(Tile[,] grid, int x, int y)
        {
            if (grid == null) throw new ArgumentNullException();

            Tile cell = grid[x, y];

            if (cell.IsMined)
                return grid;

            cell.IsCleared = true;
            _tilePainter.PaintMineCount(grid, x, y);

            if (cell.LblMineCount.Text != "0")
                return grid;

            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i > 0 && i < grid.GetLength(0) && j > 0 && j < grid.GetLength(1))
                    {
                        Tile neighbour = grid[i, j];
                        if (!neighbour.IsCleared)
                        {
                            _tilePainter.PaintMineCount(grid, i, j);
                            Tile.TileCount--;
                            CascadeTile(grid, i, j);                            
                        }
                    }
                }
            return grid;
        }

        public Tile[,] CascadeAll(Tile[,] grid)
        {
            if (grid == null) throw new ArgumentNullException();

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].IsMined)
                        _tilePainter.PaintMine(grid, i, j);

                    _tilePainter.PaintMineCount(grid, i, j);
                }
            }
            return grid;
        }
    }
}
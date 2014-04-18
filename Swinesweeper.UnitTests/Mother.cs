using Swinesweeper.GameModeFactory;
using Swinesweeper.GamePlay;
using System.Collections.Generic;

namespace Swinesweeper.UnitTests
{
    public static class Mother
    {
        public static Tile[,] GetCustomTestGrid(int xDim, int yDim)
        {
            var grid = new Tile[xDim, yDim];

            for (int i = 0; i < xDim; i++)
            {
                for (int j = 0; j < yDim; j++)
                {
                    var tile = new Tile();

                    grid[i, j] = tile;
                }
            }
            return grid;
        }

        public static Tile[,] GetTestGrid(GridSize gridSize)
        {
            int xDim = (int) gridSize;
            int yDim = (int) gridSize;

            var grid = new Tile[xDim, yDim];

            for (int i = 0; i < xDim; i++)
            {
                for (int j = 0; j < yDim; j++)
                {
                    var tile = new Tile();

                    grid[i, j] = tile;
                }
            }
            return grid;
        }

        public static int[] GetTestCoordinates(GridSize gridSize)
        {
            int xDim = (int)gridSize;
            int yDim = (int)gridSize;

            var intList = new List<int>();

            var grid = new Tile[xDim, yDim];

            for (int i = 0; i < xDim; i++)
            {
                for (int j = 0; j < yDim; j++)
                {
                    var tile = new Tile();
                    grid[i, j] = tile;

                    intList.Add(i);
                    intList.Add(j);
                }
            }
            return intList.ToArray();
        }
    }
}

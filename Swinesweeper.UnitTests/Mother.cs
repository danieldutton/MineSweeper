using Swinesweeper.GamePlay;

namespace Swinesweeper.UnitTests
{
    public static class Mother
    {
        public static Tile[,] GetTestGrid(int xDim, int yDim)
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
    }
}

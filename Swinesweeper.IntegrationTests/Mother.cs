using Swinesweeper.GamePlay;

namespace Swinesweeper.IntegrationTests
{
    public static class Mother
    {
        public static Tile[,] GetTiledGrid_10_by_10_NoMines()
        {
            var grid = new Tile[10,10];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = new Tile();    
                }
            }
            return grid;
        }
    }
}

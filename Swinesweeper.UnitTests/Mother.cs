using Swinesweeper.GamePlay;

namespace Swinesweeper.UnitTests
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

        public static Tile[,] GetTiledGrid_10_by_10_With_5_Mines()
        {
            var grid = new Tile[10, 10];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = new Tile();

                    if (i%2 == 0)
                        grid[i, j].IsMined = true;
                }//errors in here.  Only ten tiles are being populated
            }
            return grid;
        }
    }
}

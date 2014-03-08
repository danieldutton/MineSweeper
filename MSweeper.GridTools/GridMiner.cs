using MSweeper.GameModeFactory.Settings;
using MSweeper.GridTools.Interfaces;
using MSweeper.Model;
using MSweeper.Utilities.Interfaces;


namespace MSweeper.GridTools
{
    public class GridMiner : IGridMiner
    {
        private readonly IRandomNumberGenerator _randomNumberGenerator;


        public GridMiner(IRandomNumberGenerator randomNumberGenerator)
        {
            _randomNumberGenerator = randomNumberGenerator;
        }

        public Tile[,] MineTheGrid(Tile[,] grid, DifficultyLevel gameMode, GridSize gridSize)
        {
            for (int i = 0; i < (int) gameMode; i++)
                ExtractAMineFreeTile(grid, gridSize);

            return grid;
        }

        private void ExtractAMineFreeTile(Tile[,] grid, GridSize gridSize)
        {
            int xIndex = _randomNumberGenerator.GetRandomNumber(0, (int) gridSize);
            int yIndex = _randomNumberGenerator.GetRandomNumber(0, (int) gridSize);

            Tile tile = grid[xIndex, yIndex];

            if (tile.IsMined)
                ExtractAMineFreeTile(grid, gridSize);

            else
                tile.IsMined = true;
        }
    }
}
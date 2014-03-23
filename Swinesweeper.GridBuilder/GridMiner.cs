using Swinesweeper.GameModeFactory;
using Swinesweeper.GamePlay;
using Swinesweeper.GridBuilder.Interfaces;
using Swinesweeper.Utilities.Interfaces;
using System;

namespace Swinesweeper.GridBuilder
{
    public class GridMiner : IGridMiner
    {
        private readonly IRandomNumberGenerator _randomNumberGenerator;


        public GridMiner(IRandomNumberGenerator randomNumberGenerator)
        {
            _randomNumberGenerator = randomNumberGenerator;
        }

        public Tile[,] MineTheGrid(Tile[,] grid, DifficultyLevel difficultyLevel, GridSize gridSize)
        {
            if(grid == null) throw new ArgumentNullException("grid");

            for (int i = 0; i < (int) difficultyLevel; i++)
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
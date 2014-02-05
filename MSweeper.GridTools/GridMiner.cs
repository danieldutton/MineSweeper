using MSweeper.GridTools.Interfaces;
using MSweeper.Model.Components;
using MSweeper.Settings;
using MSweeper.Utilities.Interfaces;
using DifficultyLevel = MSweeper.GridTools.Settings.DifficultyLevel;
using GridSize = MSweeper.GridTools.Settings.GridSize;

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
            for (int i = 0; i < (int)gameMode; i++)
            {
                Tile tile = ExtractAMineFreeTile(grid, gridSize);
                tile.IsMined = true;     
            }
            return grid;
        }

        private Tile ExtractAMineFreeTile(Tile[,] grid, GridSize gridSize)
        {         
            int xIndex = _randomNumberGenerator.GetRandomNumber(1, (int)gridSize);
            int yIndex = _randomNumberGenerator.GetRandomNumber(1, (int)gridSize);

            Tile tile = grid[xIndex, yIndex];

            if (tile.IsMined)
                ExtractAMineFreeTile(grid, gridSize);
            
            return tile;
        }
    }
}

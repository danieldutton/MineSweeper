using Swinesweeper.GameModeFactory;
using Swinesweeper.GamePlay;

namespace Swinesweeper.GridBuilder.Interfaces
{
    public interface IGridMiner
    {
        Tile[,] MineTheGrid(Tile[,] grid, DifficultyLevel difficultyLevel, GridSize gridSize);
    }
}

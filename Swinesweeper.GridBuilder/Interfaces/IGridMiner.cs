using Swinesweeper.GameModeFactory.Settings;
using Swinesweeper.GamePlay;

namespace Swinesweeper.GridBuilder.Interfaces
{
    public interface IGridMiner
    {
        Tile[,] MineTheGrid(Tile[,] grid, DifficultyLevel gameMode, GridSize gridSize);
    }
}

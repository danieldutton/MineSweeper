using Swinesweeper.GameModeFactory.Settings;
using Swinesweeper.Model;

namespace Swinesweeper.GridTools.Interfaces
{
    public interface IGridMiner
    {
        Tile[,] MineTheGrid(Tile[,] grid, DifficultyLevel gameMode, GridSize gridSize);
    }
}

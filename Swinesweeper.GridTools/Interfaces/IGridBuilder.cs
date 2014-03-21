using Swinesweeper.GameModeFactory.Settings;
using Swinesweeper.Model;

namespace Swinesweeper.GridTools.Interfaces
{
    public interface IGridBuilder
    {
        Tile[,] GetSquaredGrid(GridSize gridSize, DifficultyLevel difficultyLevel);
    }
}

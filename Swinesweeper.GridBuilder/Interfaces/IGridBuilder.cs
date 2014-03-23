using Swinesweeper.GameModeFactory;
using Swinesweeper.GamePlay;

namespace Swinesweeper.GridBuilder.Interfaces
{
    public interface IGridBuilder
    {
        Tile[,] GetSquaredGrid(GridSize gridSize, DifficultyLevel difficultyLevel);
    }
}

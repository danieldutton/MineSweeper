using MSweeper.GameModeFactory.Settings;
using MSweeper.Model;

namespace MSweeper.GridTools.Interfaces
{
    public interface IGridMiner
    {
        Tile[,] MineTheGrid(Tile[,] grid, DifficultyLevel gameMode, GridSize gridSize);
    }
}

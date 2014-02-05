using MSweeper.Model.Components;
using MSweeper.Settings;
using DifficultyLevel = MSweeper.GridTools.Settings.DifficultyLevel;
using GridSize = MSweeper.GridTools.Settings.GridSize;

namespace MSweeper.GridTools.Interfaces
{
    public interface IGridMiner
    {
        Tile[,] MineTheGrid(Tile[,] grid, DifficultyLevel gameMode, GridSize gridSize);
    }
}

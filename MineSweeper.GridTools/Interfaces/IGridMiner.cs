using MineSweeper.Model.Components;
using MineSweeper.Settings;

namespace MineSweeper.GridTools.Interfaces
{
    public interface IGridMiner
    {
        Tile[,] MineTheGrid(Tile[,] grid, DifficultyLevel gameMode, GridSize gridSize);
    }
}

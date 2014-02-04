using MSweeper.Model.Components;
using MSweeper.Settings;

namespace MSweeper.GridTools.Interfaces
{
    public interface IGridMiner
    {
        Tile[,] MineTheGrid(Tile[,] grid, DifficultyLevel gameMode, GridSize gridSize);
    }
}

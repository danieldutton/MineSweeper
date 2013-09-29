using MineSweeper.Model.Components;
using MineSweeper.Settings;

namespace MineSweeper.GridTools.Interfaces
{
    public interface IGridGenerator
    {
        Tile[,] GetSquaredGrid(GridSize gridSize);
    }
}

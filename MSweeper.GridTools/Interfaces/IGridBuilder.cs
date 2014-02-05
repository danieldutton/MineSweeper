using MSweeper.GridTools.Settings;
using MSweeper.Model.Components;

namespace MSweeper.GridTools.Interfaces
{
    public interface IGridBuilder
    {
        Tile[,] GetSquaredGrid(GridSize gridSize);
    }
}

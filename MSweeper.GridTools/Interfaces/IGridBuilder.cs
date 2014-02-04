using MSweeper.Model.Components;
using MSweeper.Settings;

namespace MSweeper.GridTools.Interfaces
{
    public interface IGridBuilder
    {
        Tile[,] GetSquaredGrid(GridSize gridSize);
    }
}

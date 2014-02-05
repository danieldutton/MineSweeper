using MSweeper.Model.Components;
using MSweeper.Settings;
using GridSize = MSweeper.GridTools.Settings.GridSize;

namespace MSweeper.GridTools.Interfaces
{
    public interface IGridBuilder
    {
        Tile[,] GetSquaredGrid(GridSize gridSize);
    }
}

using MSweeper.GameModeFactory.Settings;
using MSweeper.Model;

namespace MSweeper.GridTools.Interfaces
{
    public interface IGridBuilder
    {
        Tile[,] GetSquaredGrid(GridSize gridSize);
    }
}

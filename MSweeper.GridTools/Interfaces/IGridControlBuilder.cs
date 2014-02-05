using MSweeper.Settings;
using System.Windows.Forms;
using GridSize = MSweeper.GridTools.Settings.GridSize;

namespace MSweeper.GridTools.Interfaces
{
    public interface IGridControlBuilder
    {
        Control AddControlsToGrid<T>(T[,] controlsToAdd, Control control, GridSize gridSize)
            where T : Control;
    }
}

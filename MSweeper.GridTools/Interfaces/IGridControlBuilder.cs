using MSweeper.GridTools.Settings;
using System.Windows.Forms;

namespace MSweeper.GridTools.Interfaces
{
    public interface IGridControlBuilder
    {
        Control AddControlsToGrid<T>(T[,] controlsToAdd, Control control, GridSize gridSize)
            where T : Control;
    }
}

using System.Windows.Forms;
using Swinesweeper.GameModeFactory.Settings;

namespace Swinesweeper.GridTools.Interfaces
{
    public interface IGridControlBuilder
    {
        Control AddControlsToGrid<T>(T[,] controlsToAdd, Control control, GridSize gridSize)
            where T : Control;
    }
}

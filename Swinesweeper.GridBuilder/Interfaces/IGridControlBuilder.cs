using Swinesweeper.GameModeFactory;
using System.Windows.Forms;

namespace Swinesweeper.GridBuilder.Interfaces
{
    public interface IGridControlBuilder
    {
        Control AddControlsToGrid<T>(T[,] controlsToAdd, Control control, GridSize gridSize)
            where T : Control;
    }
}

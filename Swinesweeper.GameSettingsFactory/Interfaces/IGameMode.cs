using Swinesweeper.GameModeFactory.Settings;
using System.Drawing;

namespace Swinesweeper.GameModeFactory.Interfaces
{
    public interface IGameMode
    {
        Point FormSize { get; }

        Point GridPanelSize { get; }

        DifficultyLevel DifficultyLevel { get; }

        GridSize GridSize { get; }
    }
}

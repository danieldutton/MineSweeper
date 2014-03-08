using MSweeper.GameModeFactory.Settings;
using System.Drawing;

namespace MSweeper.GameModeFactory.Interfaces
{
    public interface IGameMode
    {
        Point FormSize { get; }

        Point GridPanelSize { get; }

        DifficultyLevel DifficultyLevel { get; }

        GridSize GridSize { get; }
    }
}

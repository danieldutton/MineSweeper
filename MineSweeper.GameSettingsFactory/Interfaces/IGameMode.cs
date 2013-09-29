using MineSweeper.Settings;
using System.Drawing;

namespace MineSweeper.GameModeFactory.Interfaces
{
    public interface IGameMode
    {
        Point FormSize { get; set; }

        Point GridPanelSize { get; set; }

        DifficultyLevel DifficultyLevel { get; set; }

        GridSize GridSize { get; set; }
    }
}

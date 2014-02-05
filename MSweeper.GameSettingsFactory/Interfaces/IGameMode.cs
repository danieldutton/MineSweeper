using System.Drawing;
using MSweeper.GridTools.Settings;

namespace MSweeper.GameModeFactory.Interfaces
{
    public interface IGameMode
    {
        Point FormSize { get; set; }

        Point GridPanelSize { get; set; }

        DifficultyLevel DifficultyLevel { get; set; }

        GridSize GridSize { get; set; }
    }
}

using System.Drawing;

namespace MSweeper.Settings.Interfaces
{
    public interface IGameMode
    {
        Point FormSize { get; set; }

        Point GridPanelSize { get; set; }

        DifficultyLevel DifficultyLevel { get; set; }

        GridSize GridSize { get; set; }
    }
}

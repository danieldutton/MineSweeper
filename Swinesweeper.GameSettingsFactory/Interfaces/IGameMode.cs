using System.Drawing;

namespace Swinesweeper.GameModeFactory.Interfaces
{
    public interface IGameMode
    {
        Point FormSize { get; }

        GridSize GridSize { get; }

        Point GridPanelSize { get; }

        DifficultyLevel DifficultyLevel { get; }        
    }
}

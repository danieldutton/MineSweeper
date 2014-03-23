using Swinesweeper.GameModeFactory.Interfaces;
using System.Drawing;

namespace Swinesweeper.GameModeFactory.GameModes
{
    public sealed class Null : IGameMode
    {
        public Point FormSize { get; private set; }
        
        public Point GridPanelSize { get; private set; }
        
        public DifficultyLevel DifficultyLevel { get; private set; }
        
        public GridSize GridSize { get; private set; }
    }
}

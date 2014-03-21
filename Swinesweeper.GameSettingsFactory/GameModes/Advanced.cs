using Swinesweeper.GameModeFactory.Interfaces;
using Swinesweeper.GameModeFactory.Settings;
using System.Drawing;

namespace Swinesweeper.GameModeFactory.GameModes
{
    public sealed class Advanced : IGameMode
    {
        public Point FormSize { get; private set; }
        
        public Point GridPanelSize { get; private set; }

        public DifficultyLevel DifficultyLevel { get; private set; }

        public GridSize GridSize { get; private set; }


        public Advanced()
        {
            FormSize = new Point(399, 450);
            GridPanelSize = new Point(350, 329);
            DifficultyLevel = DifficultyLevel.Advanced;
            GridSize = GridSize.Advanced;
        }
    }
}

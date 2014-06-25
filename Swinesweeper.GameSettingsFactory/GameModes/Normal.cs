using Swinesweeper.GameModeFactory.Interfaces;
using System.Drawing;

namespace Swinesweeper.GameModeFactory.GameModes
{
    public sealed class Normal : IGameMode
    {
        public Point FormSize { get; private set; }

        public Point GridPanelSize { get; private set; }

        public DifficultyLevel DifficultyLevel { get; private set; }

        public GridSize GridSize { get; private set; }


        public Normal()
        {
            FormSize = new Point(327, 459);
            GridPanelSize = new Point(275, 100);
            DifficultyLevel = DifficultyLevel.Normal;
            GridSize = GridSize.Normal;
        }
    }
}

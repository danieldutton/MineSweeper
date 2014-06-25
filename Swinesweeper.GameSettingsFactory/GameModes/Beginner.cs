using Swinesweeper.GameModeFactory.Interfaces;
using System.Drawing;

namespace Swinesweeper.GameModeFactory.GameModes
{
    public sealed class Beginner : IGameMode
    {
        public Point FormSize { get; private set; }

        public Point GridPanelSize { get; private set; }

        public DifficultyLevel DifficultyLevel { get; private set; }

        public GridSize GridSize { get; private set; }


        public Beginner()
        {
            FormSize = new Point(202, 330);
            GridPanelSize = new Point(160, 100);
            DifficultyLevel = DifficultyLevel.Beginner;
            GridSize = GridSize.Beginner;
        }
    }
}

using MSweeper.GameModeFactory.Interfaces;
using MSweeper.GameModeFactory.Settings;
using System.Drawing;

namespace MSweeper.GameModeFactory.GameModes
{
    public sealed class Beginner : IGameMode
    {
        public Point FormSize { get; private set; }

        public Point GridPanelSize { get; private set; }

        public DifficultyLevel DifficultyLevel { get; private set; }

        public GridSize GridSize { get; private set; }


        public Beginner()
        {
            FormSize = new Point(183, 225);
            GridPanelSize = new Point(140, 100);
            DifficultyLevel = DifficultyLevel.Beginner;
            GridSize = GridSize.Beginner;
        }
    }
}

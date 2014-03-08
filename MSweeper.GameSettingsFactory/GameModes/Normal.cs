using MSweeper.GameModeFactory.Interfaces;
using MSweeper.GameModeFactory.Settings;
using System.Drawing;

namespace MSweeper.GameModeFactory.GameModes
{
    public class Normal : IGameMode
    {
        public Point FormSize { get; private set; }

        public Point GridPanelSize { get; private set; }

        public DifficultyLevel DifficultyLevel { get; private set; }

        public GridSize GridSize { get; private set; }


        public Normal()
        {
            FormSize = new Point(295, 340);
            GridPanelSize = new Point(240, 100);
            DifficultyLevel = DifficultyLevel.Normal;
            GridSize = GridSize.Normal;
        }
    }
}

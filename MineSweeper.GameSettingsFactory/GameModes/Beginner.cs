using MineSweeper.Settings;
using MineSweeper.Settings.Interfaces;
using System.Drawing;

namespace MineSweeper.GameModeFactory.GameModes
{
    public class Beginner : IGameMode
    {
        public Point FormSize { get; set; }
        
        public Point GridPanelSize { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public GridSize GridSize { get; set; }


        public Beginner()
        {
            FormSize = new Point(183, 225);
            GridPanelSize = new Point(140, 100);
            DifficultyLevel = DifficultyLevel.Beginner;
            GridSize = GridSize.Beginner;
        }
    }
}

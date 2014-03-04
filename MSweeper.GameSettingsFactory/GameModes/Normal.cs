using MSweeper.GameModeFactory.Interfaces;
using MSweeper.GameModeFactory.Settings;
using System.Drawing;

namespace MSweeper.GameModeFactory.GameModes
{
    public class Normal : IGameMode
    {
        public Point FormSize { get; set; }
        
        public Point GridPanelSize { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public GridSize GridSize { get; set; }


        public Normal()
        {
            FormSize = new Point(295, 340);
            GridPanelSize = new Point(240, 100);
            DifficultyLevel = DifficultyLevel.Normal;
            GridSize = GridSize.Normal;
        }
    }
}

using MineSweeper.Settings;
using MineSweeper.Settings.Interfaces;
using System.Drawing;


namespace MineSweeper.GameModeFactory.GameModes
{
    public class Advanced : IGameMode
    {
        public Point FormSize { get; set; }
        
        public Point GridPanelSize { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public GridSize GridSize { get; set; }


        public Advanced()
        {
            FormSize = new Point(359, 436);
            GridPanelSize = new Point(314, 329);
            DifficultyLevel = DifficultyLevel.Advanced;
            GridSize = GridSize.Advanced;
        }
    }
}
